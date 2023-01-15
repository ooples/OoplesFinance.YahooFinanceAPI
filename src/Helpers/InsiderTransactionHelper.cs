namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class InsiderTransactionHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Insider Transactions Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var insiderTransactionData = JsonSerializer.Deserialize<InsiderTransactionData>(jsonData);

        return insiderTransactionData != null ? (IEnumerable<T>)insiderTransactionData.QuoteSummary.Results.Select(x => x.InsiderTransactions).First().Transactions : Enumerable.Empty<T>();
    }
}
