namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class EsgScoresHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Esg Scores data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var esgScores = JsonSerializer.Deserialize<EsgScoresData>(jsonData);

        return esgScores != null ? (IEnumerable<T>)esgScores.QuoteSummary.Results.Select(x => x.EsgScores) : Enumerable.Empty<T>();
    }
}
