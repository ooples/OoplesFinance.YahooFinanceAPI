namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class EarningsHistoryHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Earnings History data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var earningsHistory = JsonConvert.DeserializeObject<EarningsHistoryData>(jsonData);
        var result = earningsHistory != null ? (IEnumerable<T>?)earningsHistory.QuoteSummary.Results.Select(x => x.EarningsHistory).FirstOrDefault()?.History : [];

        return result ?? [];
    }
}
