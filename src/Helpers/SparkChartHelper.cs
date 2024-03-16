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
        var root = JObject.Parse(jsonData).Children().FirstOrDefault();
        var result = root?.FirstOrDefault()?.ToObject<SparkInfo>();

        return new[] { result }.Cast<T>();
    }
}
