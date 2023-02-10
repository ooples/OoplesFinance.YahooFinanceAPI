namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class DayGainersLosersHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Day Gainers data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var dayGainersLosers = JsonConvert.DeserializeObject<DayGainersLosersData>(jsonData);

        return dayGainersLosers != null ? (IEnumerable<T>)dayGainersLosers.Finance.Results : Enumerable.Empty<T>();
    }
}
