namespace OoplesFinance.YahooFinanceAPI.Interfaces;

internal interface IYahooClient
{
    IEnumerable<T> ParseYahooData<T>(string csvData);

    Task<IEnumerable<T>> DownloadYahooDataAsync<T>(string symbol, DataType dataType, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true);
}
