namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class StockSplitHelper : YahooCsvBase
{
    /// <summary>
    /// Parses the raw csv data for the Stock Split Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvData"></param>
    /// <returns>Returns a IEnumerable<StockSplitData> using the given csvData</returns>
    internal override IEnumerable<T> ParseYahooCsvData<T>(IEnumerable<string[]> csvData)
    {
        var parsedDataList = csvData.Select(csvRow =>
        {
            // Perform a try parse for all columns per row
            var dateSuccess = DateTime.TryParse(csvRow[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate);

            // Add either the parsed value or the default if there was a parsing error
            StockSplitData stockSplitData = new()
            {
                Date = dateSuccess ? parsedDate : default,
                StockSplit = csvRow.Length > 1 ? csvRow[1] : string.Empty
            };

            return stockSplitData;
        });

        return (IEnumerable<T>)parsedDataList;
    }
}