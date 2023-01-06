namespace OoplesFinance.YahooFinanceAPI.Helpers;

public class StockSplitHelper : YahooClientBase
{
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
