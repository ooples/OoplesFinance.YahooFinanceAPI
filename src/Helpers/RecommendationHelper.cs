namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class RecommendationHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var rawRecommendData = JsonSerializer.Deserialize<RecommendData>(jsonData);

        return rawRecommendData != null ? (IEnumerable<T>)rawRecommendData.Finance.Results.First().RecommendedSymbols : Enumerable.Empty<T>();
    }
}
