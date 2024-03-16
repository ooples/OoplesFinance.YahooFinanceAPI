namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class CashflowStatementHistoryHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Cashflow Statement History data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var balanceSheetHistory = JsonConvert.DeserializeObject<CashflowStatementHistoryData>(jsonData);

        return balanceSheetHistory != null ? (IEnumerable<T>)balanceSheetHistory.QuoteSummary.Results.
            Select(x => x.CashflowStatementHistory).First().CashflowStatements : [];
    }
}
