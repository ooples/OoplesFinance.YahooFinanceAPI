namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class BalanceSheetHistoryQuarterlyHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Balance Sheet History Quarterly data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var balanceSheetHistoryQuarterlyData = JsonConvert.DeserializeObject<BalanceSheetHistoryQuarterlyData>(jsonData);

        return balanceSheetHistoryQuarterlyData != null ? (IEnumerable<T>)balanceSheetHistoryQuarterlyData.QuoteSummary.Results.
            Select(x => x.BalanceSheetHistoryQuarterly).First().BalanceSheetStatements : Enumerable.Empty<T>();
    }
}
