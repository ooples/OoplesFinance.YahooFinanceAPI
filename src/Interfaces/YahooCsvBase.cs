namespace OoplesFinance.YahooFinanceAPI.Interfaces;

internal abstract class YahooCsvBase
{
    internal abstract IEnumerable<T> ParseYahooCsvData<T>(IEnumerable<string[]> csvData);
}
