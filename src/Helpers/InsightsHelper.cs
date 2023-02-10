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

        return insights != null ? Enumerable.Cast<T>(new InsightsResult[] { insights.Finance.Result }) : Enumerable.Empty<T>();
    }
}
