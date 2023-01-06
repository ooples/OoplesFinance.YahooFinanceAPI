namespace OoplesFinance.YahooFinanceAPI.Helpers;

public class CapitalGainHelper : YahooClientBase
{
    internal override IEnumerable<T> ParseYahooData<T>(string? csvData)
    {
        var parsedDataList = new List<CapitalGainData>();
        var rows = csvData?.Split('\n');

        if (rows == null || rows.Length <= 1)
        {
            throw new InvalidOperationException("No Capital Gain Data Found");
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
                var capitalGainSuccess = double.TryParse(column[1], NumberStyles.Number | NumberStyles.AllowDecimalPoint | NumberStyles.Float, 
                    CultureInfo.InvariantCulture, out var parsedCapitalGain);

                // Add either the parsed value or the default if there was a parsing error
                CapitalGainData capitalGainData = new()
                {
                    Date = dateSuccess ? parsedDate : default,
                    CapitalGain = capitalGainSuccess ? parsedCapitalGain : default
                };
                parsedDataList.Add(capitalGainData);
            }
        }

        return (IEnumerable<T>)parsedDataList;
    }
}
