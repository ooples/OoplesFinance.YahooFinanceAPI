namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class EarningsTrendHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Earnings Trend data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var earningsTrend = JsonConvert.DeserializeObject<EarningsTrendData>(jsonData);

        return earningsTrend != null ? (IEnumerable<T>)earningsTrend.QuoteSummary.Results.
            Select(x => x.EarningsTrend).First().Trends : [];
    }
}
