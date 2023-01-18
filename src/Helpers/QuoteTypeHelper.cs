namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class QuoteTypeHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Quote Type data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var quoteType = JsonSerializer.Deserialize<QuoteTypeData>(jsonData);

        return quoteType != null ? (IEnumerable<T>)quoteType.QuoteSummary.Results.Select(x => x.QuoteType) : Enumerable.Empty<T>();
    }
}
