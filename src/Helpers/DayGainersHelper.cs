namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class DayGainersHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Day Gainers data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var dayGainers = JsonSerializer.Deserialize<DayGainersData>(jsonData);

        return dayGainers != null ? (IEnumerable<T>)dayGainers.Finance.Results : Enumerable.Empty<T>();
    }
}
