namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class ScreenerHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Screener data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var screener = JsonConvert.DeserializeObject<ScreenerData>(jsonData);

        return screener != null ? (IEnumerable<T>)screener.Finance.Results : [];
    }
}
