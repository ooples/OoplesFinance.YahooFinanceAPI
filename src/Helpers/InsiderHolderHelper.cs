namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class InsiderHolderHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var insiderHolderData = JsonSerializer.Deserialize<InsiderHolderData>(jsonData);

        return insiderHolderData != null ? (IEnumerable<T>)insiderHolderData.QuoteSummary.Results.Select(x => x.InsiderHolders).First().Holders : Enumerable.Empty<T>();
    }
}
