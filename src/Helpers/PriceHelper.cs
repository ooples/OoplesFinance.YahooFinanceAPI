namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class PriceHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Price data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var priceInfo = JsonSerializer.Deserialize<PriceData>(jsonData);

        return priceInfo != null ? (IEnumerable<T>)priceInfo.QuoteSummary.Results.Select(x => x.Price) : Enumerable.Empty<T>();
    }
}
