namespace OoplesFinance.YahooFinanceAPI;

public static class YahooClient
{
    /// <summary>
    /// Gets a list of all Historical Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
    {
        return new HistoricalHelper().ParseYahooCsvData<HistoricalData>(
            await DownloadRawCsvDataAsync(symbol, DataType.HistoricalPrices, dataFrequency, startDate, null, true));
    }

    /// <summary>
    /// Gets a list of all Historical Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency,
        DateTime startDate, DateTime? endDate)
    {
        return new HistoricalHelper().ParseYahooCsvData<HistoricalData>(
            await DownloadRawCsvDataAsync(symbol, DataType.HistoricalPrices, dataFrequency, startDate, endDate, true));
    }

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
        DateTime startDate, DateTime? endDate, bool includeAdjustedClose)
    {
        return new HistoricalHelper().ParseYahooCsvData<HistoricalData>(
            await DownloadRawCsvDataAsync(symbol, DataType.HistoricalPrices, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    /// <summary>
    /// Gets a list of all Dividend Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
    {
        return new DividendHelper().ParseYahooCsvData<DividendData>(
            await DownloadRawCsvDataAsync(symbol, DataType.Dividends, dataFrequency, startDate, null, true));
    }

    /// <summary>
    /// Gets a list of all Dividend Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency,
        DateTime startDate, DateTime? endDate)
    {
        return new DividendHelper().ParseYahooCsvData<DividendData>(
            await DownloadRawCsvDataAsync(symbol, DataType.Dividends, dataFrequency, startDate, endDate, true));
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
        DateTime startDate, DateTime? endDate, bool includeAdjustedClose)
    {
        return new DividendHelper().ParseYahooCsvData<DividendData>(
            await DownloadRawCsvDataAsync(symbol, DataType.Dividends, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    /// <summary>
    /// Gets a list of all Stock Split Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
    {
        return new StockSplitHelper().ParseYahooCsvData<StockSplitData>(
            await DownloadRawCsvDataAsync(symbol, DataType.StockSplits, dataFrequency, startDate, null, true));
    }

    /// <summary>
    /// Gets a list of all Stock Split Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency,
        DateTime startDate, DateTime? endDate)
    {
        return new StockSplitHelper().ParseYahooCsvData<StockSplitData>(
            await DownloadRawCsvDataAsync(symbol, DataType.StockSplits, dataFrequency, startDate, endDate, true));
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
        DateTime startDate, DateTime? endDate, bool includeAdjustedClose)
    {
        return new StockSplitHelper().ParseYahooCsvData<StockSplitData>(
            await DownloadRawCsvDataAsync(symbol, DataType.StockSplits, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    /// <summary>
    /// Gets a list of all Capital Gain Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
    {
        return new CapitalGainHelper().ParseYahooCsvData<CapitalGainData>(
            await DownloadRawCsvDataAsync(symbol, DataType.CapitalGains, dataFrequency, startDate, null, true));
    }

    /// <summary>
    /// Gets a list of all Capital Gain Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency,
        DateTime startDate, DateTime? endDate)
    {
        return new CapitalGainHelper().ParseYahooCsvData<CapitalGainData>(
            await DownloadRawCsvDataAsync(symbol, DataType.CapitalGains, dataFrequency, startDate, endDate, true));
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
        DateTime startDate, DateTime? endDate, bool includeAdjustedClose)
    {
        return new CapitalGainHelper().ParseYahooCsvData<CapitalGainData>(
            await DownloadRawCsvDataAsync(symbol, DataType.CapitalGains, dataFrequency, startDate, endDate, includeAdjustedClose));
    }

    /// <summary>
    /// Gets a list of the Top Trending Stocks using the selected parameter options
    /// </summary>
    /// <param name="country"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<string>> GetTopTrendingStocksAsync(Country country, int count)
    {
        return new TrendingHelper().ParseYahooJsonData<string>(await DownloadTrendingDataAsync(country, count));
    }

    /// <summary>
    /// Gets a list of the Top Recommendations using the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public static async Task<IEnumerable<RecommendedSymbol>> GetStockRecommendationsAsync(string symbol)
    {
        return new RecommendationHelper().ParseYahooJsonData<RecommendedSymbol>(await DownloadRecommendDataAsync(symbol));
    }

    /// <summary>
    /// Gets key statistics for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public static async Task<KeyStatistics> GetKeyStatisticsAsync(string symbol)
    {
        return new KeyStatisticsHelper().ParseYahooJsonData<KeyStatistics>(await DownloadStatsDataAsync(symbol, Country.UnitedStates, Language.English, Module.KeyStatistics)).First();
    }

    /// <summary>
    /// Gets key statistics for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public static async Task<KeyStatistics> GetKeyStatisticsAsync(string symbol, Country country, Language language)
    {
        return new KeyStatisticsHelper().ParseYahooJsonData<KeyStatistics>(await DownloadStatsDataAsync(symbol, country, language, Module.KeyStatistics)).First();
    }

    /// <summary>
    /// Gets key statistics for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="country"></param>
    /// <returns></returns>
    public static async Task<KeyStatistics> GetKeyStatisticsAsync(string symbol, Country country)
    {
        return new KeyStatisticsHelper().ParseYahooJsonData<KeyStatistics>(await DownloadStatsDataAsync(symbol, country, Language.English, Module.KeyStatistics)).First();
    }

    /// <summary>
    /// Gets key statistics for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    public static async Task<KeyStatistics> GetKeyStatisticsAsync(string symbol, Language language)
    {
        return new KeyStatisticsHelper().ParseYahooJsonData<KeyStatistics>(await DownloadStatsDataAsync(symbol, Country.UnitedStates, language, Module.KeyStatistics)).First();
    }
}