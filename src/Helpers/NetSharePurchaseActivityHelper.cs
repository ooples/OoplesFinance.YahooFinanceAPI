namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class NetSharePurchaseActivityHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Net Share Purchase Activity data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var netSharePurchaseActivity = JsonConvert.DeserializeObject<NetSharePurchaseActivityData>(jsonData);

        return netSharePurchaseActivity != null ? (IEnumerable<T>)netSharePurchaseActivity.QuoteSummary.Results.Select(x => x.NetSharePurchaseActivity) : Enumerable.Empty<T>();
    }
}
