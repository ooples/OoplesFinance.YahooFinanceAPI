namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class IndexTrendHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Index Trend data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var indexTrend = JsonConvert.DeserializeObject<IndexTrendData>(jsonData);

        return indexTrend != null ? (IEnumerable<T>)indexTrend.QuoteSummary.Results.Select(x => x.IndexTrend) : Enumerable.Empty<T>();
    }
}
