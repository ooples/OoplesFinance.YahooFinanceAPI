namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class RecommendationHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Recommendation Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var rawRecommendData = JsonConvert.DeserializeObject<RecommendData>(jsonData);

        return rawRecommendData != null ? (IEnumerable<T>)rawRecommendData.Finance.Results.First().RecommendedSymbols : Enumerable.Empty<T>();
    }
}