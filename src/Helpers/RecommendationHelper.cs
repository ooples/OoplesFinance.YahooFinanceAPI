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
        var rawResults = rawRecommendData?.Finance.Results;

        if (rawResults == null || !rawResults.Any())
        {
            throw new InvalidOperationException("Requested Information Not Available On Yahoo Finance");
        }

        return rawRecommendData != null ? (IEnumerable<T>)rawRecommendData.Finance.Results.First().RecommendedSymbols : [];
    }
}