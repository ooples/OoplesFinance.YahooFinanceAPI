namespace OoplesFinance.YahooFinanceAPI.Interfaces;

internal abstract class YahooJsonBase
{
    internal abstract IEnumerable<T> ParseYahooJsonData<T>(string jsonData);
}
