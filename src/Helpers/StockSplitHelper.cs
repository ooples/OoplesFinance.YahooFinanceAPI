namespace OoplesFinance.YahooFinanceAPI.Helpers;

public class StockSplitHelper : YahooClientBase
{
    /// <summary>
    /// Parses the raw csv data for the Stock Split Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvData"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">Throws this exception when no stock split data is found.</exception>
    internal override IEnumerable<T> ParseYahooData<T>(string? csvData)
    {
        var parsedDataList = new List<StockSplitData>();
        var rows = csvData?.Split('\n');

        if (rows == null || rows.Length <= 1)
        {
            throw new InvalidOperationException("No Stock Split Data Found");
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

                // Add either the parsed value or the default if there was a parsing error
                StockSplitData stockSplitData = new()
                {
                    Date = dateSuccess ? parsedDate : default,
                    StockSplit = column[1]
                };
                parsedDataList.Add(stockSplitData);
            }
        }

        return (IEnumerable<T>)parsedDataList;
    }
}
