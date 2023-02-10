namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class SparkChartHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Spark Chart data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var rootObjects = JsonDocument.Parse(jsonData).RootElement.EnumerateObject();
        var sparkChartData = rootObjects.Select(x => JsonConvert.DeserializeObject<SparkInfo>(x.Value.ToString()));

        return sparkChartData != null ? (IEnumerable<T>)sparkChartData : Enumerable.Empty<T>();
    }
}
