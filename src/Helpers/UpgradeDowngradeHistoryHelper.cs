namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class UpgradeDowngradeHistoryHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Upgrade Downgrade History data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var upgradeDowngradeHistory = JsonConvert.DeserializeObject<UpgradeDowngradeHistoryData>(jsonData);

        return upgradeDowngradeHistory != null ? (IEnumerable<T>)upgradeDowngradeHistory.QuoteSummary.Results.
            Select(x => x.UpgradeDowngradeHistory).First().History : [];
    }
}
