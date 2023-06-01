namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class InsightsHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Insights data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var insights = JsonConvert.DeserializeObject<InsightsData>(jsonData);

        if (insights == null || !insights.Finance.Result.Reports.Any())
        {
            throw new InvalidOperationException("Requested Information Not Available On Yahoo Finance");
        }

        return new[] { insights.Finance.Result }.Cast<T>();
    }
}
