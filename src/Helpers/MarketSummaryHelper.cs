namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class MarketSummaryHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var marketSummary = JsonSerializer.Deserialize<MarketSummaryData>(jsonData);

        return marketSummary != null ? (IEnumerable<T>)marketSummary.MarketSummaryResponse.Results : Enumerable.Empty<T>();
    }
}
