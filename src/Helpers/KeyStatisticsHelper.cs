namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class KeyStatisticsHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Key Statistics Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var keyStatisticData = JsonSerializer.Deserialize<KeyStatisticData>(jsonData);

        return keyStatisticData != null ? (IEnumerable<T>)keyStatisticData.QuoteSummary.Results.Select(x => x.DefaultKeyStatistics) : Enumerable.Empty<T>();
    }
}
