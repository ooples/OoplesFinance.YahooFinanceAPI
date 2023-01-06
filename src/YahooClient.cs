namespace OoplesFinance.YahooFinanceAPI;

public static class YahooClient
{
    public static async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new HistoricalHelper().ParseYahooData<HistoricalData>(
            await DownloadRawDataAsync<HistoricalData>(symbol, DataType.HistoricalPrices, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    public static async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new DividendHelper().ParseYahooData<DividendData>(
            await DownloadRawDataAsync<DividendData>(symbol, DataType.Dividends, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    public static async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new StockSplitHelper().ParseYahooData<StockSplitData>(
            await DownloadRawDataAsync<StockSplitData>(symbol, DataType.StockSplits, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    public static async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new CapitalGainHelper().ParseYahooData<CapitalGainData>(
            await DownloadRawDataAsync<CapitalGainData>(symbol, DataType.CapitalGains, dataFrequency, startDate, endDate, includeAdjustedClose));
    }
}