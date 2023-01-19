namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class ChartHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Chart data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var chartData = JsonSerializer.Deserialize<ChartData>(jsonData);

        return chartData != null ? (IEnumerable<T>)chartData.Chart.Results : Enumerable.Empty<T>();
    }
}
