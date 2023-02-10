namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class MajorHoldersBreakdownHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Major Holders Breakdown data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var majorHoldersBreakdown = JsonConvert.DeserializeObject<MajorHoldersBreakdownData>(jsonData);

        return majorHoldersBreakdown != null ? (IEnumerable<T>)majorHoldersBreakdown.QuoteSummary.Results.Select(x => x.MajorHoldersBreakdown) : Enumerable.Empty<T>();
    }
}
