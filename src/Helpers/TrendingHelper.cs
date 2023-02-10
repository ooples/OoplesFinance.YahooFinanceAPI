namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class TrendingHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Trending Data
    /// </summary>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var rawTrendingData = JsonConvert.DeserializeObject<TrendingData>(jsonData);

        return rawTrendingData != null ? (IEnumerable<T>)rawTrendingData.Finance.Results.First().Quotes.Select(x => x.Symbol) : Enumerable.Empty<T>();
    }
}