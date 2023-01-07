namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class DividendHelper : YahooClientBase
{
    /// <summary>
    /// Parses the raw csv data for the Dividend Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvData"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    internal override IEnumerable<T> ParseYahooData<T>(string? csvData)
    {
        var parsedDataList = new List<DividendData>();
        var rows = csvData?.Split('\n');

        if (rows == null || rows.Length <= 1)
        {
            throw new InvalidOperationException("No Dividend Data Found");
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
                var dividendSuccess = double.TryParse(column[1], NumberStyles.AllowDecimalPoint | NumberStyles.Float | NumberStyles.Number, 
                    CultureInfo.InvariantCulture, out var parsedDividend);

                // Add either the parsed value or the default if there was a parsing error
                DividendData dividendData = new()
                {
                    Date = dateSuccess ? parsedDate : default,
                    Dividend = dividendSuccess ? parsedDividend : default
                };

                parsedDataList.Add(dividendData);
            }
        }

        return (IEnumerable<T>)parsedDataList;
    }
}
