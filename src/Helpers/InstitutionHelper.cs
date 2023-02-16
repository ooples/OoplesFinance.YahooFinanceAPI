namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class InstitutionHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Institution data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var institutionData = JsonConvert.DeserializeObject<InstitutionData>(jsonData);

        return institutionData != null ? (IEnumerable<T>)institutionData.Finance.Results : Enumerable.Empty<T>();
    }
}
