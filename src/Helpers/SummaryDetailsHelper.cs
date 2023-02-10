namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class SummaryDetailsHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var summaryDetailsData = JsonConvert.DeserializeObject<SummaryData>(jsonData);

        return summaryDetailsData != null ? (IEnumerable<T>)summaryDetailsData.QuoteSummary.Results.Select(x => x.SummaryDetail) : Enumerable.Empty<T>();
    }
}
