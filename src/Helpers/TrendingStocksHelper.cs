namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class TrendingStocksHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Trending Stocks data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var trendingStocks = JsonConvert.DeserializeObject<TrendingStocksData>(jsonData);

        return trendingStocks != null ? (IEnumerable<T>)trendingStocks.Finance.Results : [];
    }
}
