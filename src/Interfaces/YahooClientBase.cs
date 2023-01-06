namespace OoplesFinance.YahooFinanceAPI.Interfaces;

public abstract class YahooClientBase
{
    internal abstract IEnumerable<T> ParseYahooData<T>(string? csvData);
}
