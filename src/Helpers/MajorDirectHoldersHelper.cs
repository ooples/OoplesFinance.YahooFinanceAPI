namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class MajorDirectHoldersHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Major Direct Holders data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var majorDirectHolders = JsonConvert.DeserializeObject<MajorDirectHoldersData>(jsonData);

        return majorDirectHolders != null ? (IEnumerable<T>)majorDirectHolders.QuoteSummary.Results.Select(x => x.MajorDirectHolders).First().Holders : [];
    }
}
