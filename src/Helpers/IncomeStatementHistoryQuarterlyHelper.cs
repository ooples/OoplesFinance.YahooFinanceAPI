namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class IncomeStatementHistoryQuarterlyHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Income Statement History Quarterly data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var incomeStatementHistoryQuarterly = JsonConvert.DeserializeObject<IncomeStatementHistoryQuarterlyData>(jsonData);

        return incomeStatementHistoryQuarterly != null ? (IEnumerable<T>)incomeStatementHistoryQuarterly.QuoteSummary.Results.
            Select(x => x.IncomeStatementHistoryQuarterly).First().IncomeStatementHistory : Enumerable.Empty<T>();
    }
}
