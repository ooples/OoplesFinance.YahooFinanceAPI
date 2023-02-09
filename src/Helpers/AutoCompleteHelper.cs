namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class AutoCompleteHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the AutoComplete data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var autoComplete = JsonSerializer.Deserialize<AutoCompleteData>(jsonData);

        return autoComplete != null ? (IEnumerable<T>)autoComplete.ResultSet.Results : Enumerable.Empty<T>();
    }
}
