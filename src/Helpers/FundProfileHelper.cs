namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class FundProfileHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Fund Profile data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var fundProfile = JsonSerializer.Deserialize<FundProfileData>(jsonData);

        return fundProfile != null ? (IEnumerable<T>)fundProfile.QuoteSummary.Results.Select(x => x.FundProfile) : Enumerable.Empty<T>();
    }
}
