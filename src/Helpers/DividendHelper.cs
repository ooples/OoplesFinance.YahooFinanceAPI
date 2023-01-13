namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class DividendHelper : YahooCsvBase
{
    /// <summary>
    /// Parses the raw csv data for the Dividend Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvData"></param>
    /// <returns>Returns a IEnumerable<DividendData> using the given csvData</returns>
    internal override IEnumerable<T> ParseYahooCsvData<T>(IEnumerable<string[]> csvData)
    {
        var parsedDataList = csvData.Select(csvRow => 
        {
            // Perform a try parse for all columns per row
            var dateSuccess = DateTime.TryParse(csvRow[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate);
            var dividendSuccess = double.TryParse(csvRow[1], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number,
                CultureInfo.InvariantCulture, out var parsedDividend);

            // Add either the parsed value or the default if there was a parsing error
            DividendData dividendData = new()
            {
                Date = dateSuccess ? parsedDate : default,
                Dividend = dividendSuccess ? parsedDividend : default
            };

            return dividendData;
        });

        return (IEnumerable<T>)parsedDataList;
    }
}
