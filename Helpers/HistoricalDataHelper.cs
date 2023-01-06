namespace OoplesFinance.YahooFinanceAPI.Helpers;

public class HistoricalDataHelper : IYahooClient
{
    public async Task<IEnumerable<T>> DownloadYahooDataAsync<T>(string symbol, DataType dataType, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate, bool includeAdjustedClose)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, BuildYahooUrl(symbol, dataType, dataFrequency, startDate, endDate, includeAdjustedClose));
            var response = await client.SendAsync(request);

            var result = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                // Handle success
                result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (!string.IsNullOrWhiteSpace(result))
                {
                    return ParseYahooData<T>(result);
                }
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.UnprocessableEntity)
                {
                    throw new InvalidOperationException($"'{symbol}' Symbol Not Available On Yahoo Finance");
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new InvalidOperationException("Yahoo Finance Authentication Error");
                }
                else
                {
                    throw new InvalidOperationException("Unspecified Error Occurred");
                }
            }
        }

        return Enumerable.Empty<T>();
    }

    public IEnumerable<T> ParseYahooData<T>(string csvData)
    {
        var parsedDataList = new List<HistoricalData>();
        var rows = csvData.Split('\n');

        if (rows == null || rows.Length <= 1)
        {
            throw new InvalidOperationException("No Historical Data Found");
        }

        // We are ignoring the first row which are headers
        for (var i = 1; i < rows?.Length; i++)
        {
            var row = rows[i];

            if (!string.IsNullOrWhiteSpace(row))
            {
                var column = row.Split(',');

                // Perform a try parse for all columns per row
                var dateSuccess = DateTime.TryParse(column[0], CultureInfo.InvariantCulture, out var parsedDate);
                var openSuccess = double.TryParse(column[1], CultureInfo.InvariantCulture, out var parsedOpen);
                var highSuccess = double.TryParse(column[2], CultureInfo.InvariantCulture, out var parsedHigh);
                var lowSuccess = double.TryParse(column[3], CultureInfo.InvariantCulture, out var parsedLow);
                var closeSuccess = double.TryParse(column[4], CultureInfo.InvariantCulture, out var parsedClose);
                var adjCloseSuccess = double.TryParse(column[5], CultureInfo.InvariantCulture, out var parsedAdjClose);
                var volumeSuccess = double.TryParse(column[6], CultureInfo.InvariantCulture, out var parsedVolume);

                // Add either the parsed value or the default if there was a parsing error
                HistoricalData historicalData = new()
                {
                    Date = dateSuccess ? parsedDate : default,
                    Open = openSuccess ? parsedOpen : default,
                    High = highSuccess ? parsedHigh : default,
                    Low = lowSuccess ? parsedLow : default,
                    Close = closeSuccess ? parsedClose : default,
                    AdjClose = adjCloseSuccess ? parsedAdjClose : default,
                    Volume = volumeSuccess ? parsedVolume : default
                };
                parsedDataList.Add(historicalData);
            }
        }

        return (IEnumerable<T>)parsedDataList;
    }
}