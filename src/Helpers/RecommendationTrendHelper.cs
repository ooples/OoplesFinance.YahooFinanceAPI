namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class RecommendationTrendHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Recommendation Trend data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var recommendationTrend = JsonSerializer.Deserialize<RecommendationTrendData>(jsonData);

        return recommendationTrend != null ? (IEnumerable<T>)recommendationTrend.QuoteSummary.Results.Select(x => x.RecommendationTrend).First().Trend : Enumerable.Empty<T>();
    }
}
