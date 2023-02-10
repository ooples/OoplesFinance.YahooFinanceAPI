namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class EarningsHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Earnings data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var earnings = JsonConvert.DeserializeObject<EarningsData>(jsonData);

        return earnings != null ? (IEnumerable<T>)earnings.QuoteSummary.Results.Select(x => x.Earnings) : Enumerable.Empty<T>();
    }
}
