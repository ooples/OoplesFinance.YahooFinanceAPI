namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class BalanceSheetHistoryHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Balance Sheet History data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var balanceSheetHistory = JsonConvert.DeserializeObject<BalanceSheetHistoryData>(jsonData);

        return balanceSheetHistory != null ? (IEnumerable<T>)balanceSheetHistory.QuoteSummary.Results.
            Select(x => x.BalanceSheetHistory).First().BalanceSheetStatements : Enumerable.Empty<T>();
    }
}
