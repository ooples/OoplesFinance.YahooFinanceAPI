namespace OoplesFinance.YahooFinanceAPI.Helpers;

public static class DownloadHelper
{
    /// <summary>
    /// Downloads the raw csv data using the chosen parameters
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="symbol"></param>
    /// <param name="dataType"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjustedClose"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    internal static async Task<string?> DownloadRawDataAsync<T>(string symbol, DataType dataType, DataFrequency dataFrequency,
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
                result = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrWhiteSpace(result))
                {
                    return result;
                }
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
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

        return string.Empty;
    }

    /// <summary>
    /// Creates a url that will be used to compile the chosen parameter options into a csv file.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataType"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjClose"></param>
    /// <returns></returns>
    internal static Uri BuildYahooUrl(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjClose = true) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v7/finance/download/{symbol}?period1={startDate.ToUnixTimestamp()}" +
            $"&period2={(endDate ?? DateTime.Now).ToUnixTimestamp()}&interval={GetIntervalString(dataFrequency)}&events={GetEventsString(dataType)}&includeAdjustedClose={includeAdjClose}"));

    /// <summary>
    /// Returns a custom string for the Data Frequency option.
    /// </summary>
    /// <param name="dataFrequency"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators.</exception>
    private static string GetIntervalString(DataFrequency dataFrequency) =>
        dataFrequency switch
        {
            DataFrequency.Daily => "1d",
            DataFrequency.Weekly => "1wk",
            DataFrequency.Monthly => "1mo",
            _ => throw new ArgumentException("Invalid Enumerator Value", nameof(dataFrequency))
        };

    /// <summary>
    /// Returns a custom string for the Data Type option.
    /// </summary>
    /// <param name="dataType"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators.</exception>
    private static string GetEventsString(DataType dataType) =>
        dataType switch
        {
            DataType.HistoricalPrices => "history",
            DataType.Dividends => "div",
            DataType.StockSplits => "split",
            DataType.CapitalGains => "capitalGain",
            _ => throw new ArgumentException("Invalid Enumerator Value", nameof(dataType))
        };
}