namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class IncomeStatementHistoryHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Income Statement History data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var incomeStatementHistory = JsonConvert.DeserializeObject<IncomeStatementHistoryData>(jsonData);

        return incomeStatementHistory != null ? (IEnumerable<T>)incomeStatementHistory.QuoteSummary.Results.
            Select(x => x.IncomeStatementHistory).First().IncomeStatementHistoryInfo : Enumerable.Empty<T>();
    }
}
