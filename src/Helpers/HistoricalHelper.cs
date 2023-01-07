namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class HistoricalHelper : YahooClientBase
{
    /// <summary>
    /// Parses the raw csv data for the Historical Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvData"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">Throws an exception if no historical data was found.</exception>
    internal override IEnumerable<T> ParseYahooData<T>(string? csvData)
    {
        var parsedDataList = new List<HistoricalData>();
        var rows = csvData?.Split('\n');

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
                var dateSuccess = DateTime.TryParse(column[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate);
                var openSuccess = double.TryParse(column[1], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number, 
                    CultureInfo.InvariantCulture, out var parsedOpen);
                var highSuccess = double.TryParse(column[2], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number, 
                    CultureInfo.InvariantCulture, out var parsedHigh);
                var lowSuccess = double.TryParse(column[3], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number, 
                    CultureInfo.InvariantCulture, out var parsedLow);
                var closeSuccess = double.TryParse(column[4], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number, 
                    CultureInfo.InvariantCulture, out var parsedClose);
                var adjCloseSuccess = double.TryParse(column[5], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number, 
                    CultureInfo.InvariantCulture, out var parsedAdjClose);
                var volumeSuccess = double.TryParse(column[6], NumberStyles.Integer | NumberStyles.Number, 
                    CultureInfo.InvariantCulture, out var parsedVolume);

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