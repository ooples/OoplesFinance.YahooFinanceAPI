namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class FinancialDataHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Financial Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var financialData = JsonConvert.DeserializeObject<FinancialDataRoot>(jsonData);

        return financialData != null ? (IEnumerable<T>)financialData.QuoteSummary.Results.Select(x => x.FinancialData) : [];
    }
}
