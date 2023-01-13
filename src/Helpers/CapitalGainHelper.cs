namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class CapitalGainHelper : YahooCsvBase
{
    /// <summary>
    /// Parses the raw csv data for the Capital Gain Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvData"></param>
    /// <returns>Returns a IEnumerable<CapitalGainHelper> using the given csvData</returns>
    internal override IEnumerable<T> ParseYahooCsvData<T>(IEnumerable<string[]> csvData)
    {
        var parsedDataList = csvData.Select(csvRow =>
        {
            // Perform a try parse for all columns per row
            var dateSuccess = DateTime.TryParse(csvRow[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate);
            var capitalGainSuccess = double.TryParse(csvRow[1], NumberStyles.Number | NumberStyles.AllowDecimalPoint | NumberStyles.Float,
                CultureInfo.InvariantCulture, out var parsedCapitalGain);

            // Add either the parsed value or the default if there was a parsing error
            CapitalGainData capitalGainData = new()
            {
                Date = dateSuccess ? parsedDate : default,
                CapitalGain = capitalGainSuccess ? parsedCapitalGain : default
            };

            return capitalGainData;
        });

        return (IEnumerable<T>)parsedDataList;
    }
}
