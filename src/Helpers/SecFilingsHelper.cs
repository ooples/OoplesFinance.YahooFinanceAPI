namespace OoplesFinance.YahooFinanceAPI.Helpers;

/// <summary>
/// Parses the raw json data for the SEC Filings data
/// </summary>
internal class SecFilingsHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var secFilings = JsonSerializer.Deserialize<SecFilingsData>(jsonData);

        return secFilings != null ? (IEnumerable<T>)secFilings.QuoteSummary.Results.Select(x => x.SecFilings).First().Filings : Enumerable.Empty<T>();
    }
}
