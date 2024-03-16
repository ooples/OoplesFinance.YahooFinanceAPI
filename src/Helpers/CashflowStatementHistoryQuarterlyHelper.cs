namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class CashflowStatementHistoryQuarterlyHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Cashflow Statement History Quarterly data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var cashflowStatementHistoryQuarterlyData = JsonConvert.DeserializeObject<CashflowStatementHistoryQuarterlyData>(jsonData);

        return cashflowStatementHistoryQuarterlyData != null ? (IEnumerable<T>)cashflowStatementHistoryQuarterlyData.QuoteSummary.Results.
            Select(x => x.CashflowStatementHistoryQuarterly).First().CashflowStatements : [];
    }
}
