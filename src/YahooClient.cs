namespace OoplesFinance.YahooFinanceAPI;

public static class YahooClient
{
    /// <summary>
    /// Gets a list of all Historical Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjustedClose"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new HistoricalHelper().ParseYahooData<HistoricalData>(
            await DownloadRawDataAsync<HistoricalData>(symbol, DataType.HistoricalPrices, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    /// <summary>
    /// Gets a list of all Dividend Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjustedClose"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new DividendHelper().ParseYahooData<DividendData>(
            await DownloadRawDataAsync<DividendData>(symbol, DataType.Dividends, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    /// <summary>
    /// Gets a list of all Stock Split Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjustedClose"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new StockSplitHelper().ParseYahooData<StockSplitData>(
            await DownloadRawDataAsync<StockSplitData>(symbol, DataType.StockSplits, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    /// <summary>
    /// Gets a list of all Capital Gain Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjustedClose"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency, 
        DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return new CapitalGainHelper().ParseYahooData<CapitalGainData>(
            await DownloadRawDataAsync<CapitalGainData>(symbol, DataType.CapitalGains, dataFrequency, startDate, endDate, includeAdjustedClose));
    }
}