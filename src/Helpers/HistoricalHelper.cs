namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class HistoricalHelper : YahooCsvBase
{
    /// <summary>
    /// Parses the raw csv data for the Historical Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvData"></param>
    /// <returns>Returns a IEnumerable<HistoricalData> using the given csvData</returns>
    internal override IEnumerable<T> ParseYahooCsvData<T>(IEnumerable<string[]> csvData)
    {
        var parsedDataList = csvData.Select(csvRow =>
        {
            // Perform a try parse for all columns per row
            var dateSuccess = DateTime.TryParse(csvRow[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate);
            var openSuccess = double.TryParse(csvRow[1], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number,
                CultureInfo.InvariantCulture, out var parsedOpen);
            var highSuccess = double.TryParse(csvRow[2], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number,
                CultureInfo.InvariantCulture, out var parsedHigh);
            var lowSuccess = double.TryParse(csvRow[3], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number,
                CultureInfo.InvariantCulture, out var parsedLow);
            var closeSuccess = double.TryParse(csvRow[4], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number,
                CultureInfo.InvariantCulture, out var parsedClose);
            var adjCloseSuccess = double.TryParse(csvRow[5], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number,
                CultureInfo.InvariantCulture, out var parsedAdjClose);
            var volumeSuccess = double.TryParse(csvRow[6], NumberStyles.Integer | NumberStyles.Number,
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

            return historicalData;
        });

        return (IEnumerable<T>)parsedDataList;
    }
}