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
        var sparkChartData = JsonSerializer.Deserialize<SparkChartData>(jsonData);

        return sparkChartData != null ? Enumerable.Cast<T>(new SparkInfo[] { sparkChartData.Result }) : Enumerable.Empty<T>();
    }
}
