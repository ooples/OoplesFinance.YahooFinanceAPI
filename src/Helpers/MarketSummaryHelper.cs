namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class MarketSummaryHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Market Summary data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var marketSummary = JsonConvert.DeserializeObject<MarketSummaryData>(jsonData);

        return marketSummary != null ? (IEnumerable<T>)marketSummary.MarketSummaryResponse.Results : Enumerable.Empty<T>();
    }
}
