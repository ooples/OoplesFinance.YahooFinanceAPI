namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class SectorTrendHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Sector Trend data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var sectorTrend = JsonSerializer.Deserialize<SectorTrendData>(jsonData);

        return sectorTrend != null ? (IEnumerable<T>)sectorTrend.QuoteSummary.Results.Select(x => x.SectorTrend) : Enumerable.Empty<T>();
    }
}
