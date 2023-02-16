namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class AnalystHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Analyst data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var analystData = JsonConvert.DeserializeObject<AnalystData>(jsonData);

        return analystData != null ? (IEnumerable<T>)analystData.Finance.Results : Enumerable.Empty<T>();
    }
}
