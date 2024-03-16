namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class InstitutionOwnershipHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Institution Ownership data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var institutionOwnership = JsonConvert.DeserializeObject<InstitutionOwnershipData>(jsonData);

        return institutionOwnership != null ? (IEnumerable<T>)institutionOwnership.QuoteSummary.Results.Select(x => x.InstitutionOwnership).First().OwnershipList : [];
    }
}
