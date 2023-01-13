namespace OoplesFinance.YahooFinanceAPI.Interfaces;

internal abstract class YahooJsonBase
{
    internal abstract IEnumerable<string> ParseYahooJsonData(string jsonData);
}
