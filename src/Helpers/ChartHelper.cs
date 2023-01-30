using System.Text.Json.Nodes;

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
        var chartNodes = JsonNode.Parse(jsonData)!;
        var root = chartNodes["chart"]!["result"]![0];
        var dates = root!["timestamp"]!.AsArray().Select(x => x!.GetValue<long>().FromUnixTimeStamp());
        var indicatorRoot = root["indicators"]!["quote"]![0];
        var closePrices = indicatorRoot!["close"]!.AsArray().Select(x => x!= null ? Math.Round(x.GetValue<double>(), 4) : 0);
        var openPrices = indicatorRoot!["open"]!.AsArray().Select(x => x != null ? Math.Round(x.GetValue<double>(), 4) : 0);
        var lowPrices = indicatorRoot!["low"]!.AsArray().Select(x => x != null ? Math.Round(x.GetValue<double>(), 4) : 0);
        var highPrices = indicatorRoot!["high"]!.AsArray().Select(x => x != null ? Math.Round(x.GetValue<double>(), 4) : 0);
        var volumes = indicatorRoot!["volume"]!.AsArray().Select(x => x != null ? x.GetValue<double>() : 0);

        var result = new ChartData()
        {
            DateList = dates.ToList(),
            CloseList = closePrices.ToList(),
            OpenList = openPrices.ToList(),
            HighList = highPrices.ToList(),
            VolumeList = volumes.ToList(),
            LowList = lowPrices.ToList()
        };

        return Enumerable.Cast<T>(new ChartData[] { result });
    }
}
