namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class SummaryDetailsHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Summary Details data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var summaryDetailsData = JsonConvert.DeserializeObject<SummaryData>(jsonData);

        return summaryDetailsData != null ? (IEnumerable<T>)summaryDetailsData.QuoteSummary.Results.Select(x => x.SummaryDetail) : [];
    }
}
