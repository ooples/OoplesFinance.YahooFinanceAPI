namespace OoplesFinance.YahooFinanceAPI;

public class YahooClient
{
    private readonly Country Country;

    private readonly Language Language;

    public YahooClient(Country? country = null, Language? language = null)
    {
        Country = country ?? Country.UnitedStates;
        Language = language ?? Language.English;
    }

    /// <summary>
    /// Gets a list of all Historical Data for the selected stock symbol and parameter options.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <returns></returns>
    public async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
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
    public async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
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
    public async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
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
    public async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate)
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
    public async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency,
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
    public async Task<IEnumerable<string>> GetTopTrendingStocksAsync(Country country, int count)
    {
        return new TrendingHelper().ParseYahooJsonData<string>(await DownloadTrendingDataAsync(country, count));
    }

    /// <summary>
    /// Gets a list of the Top Recommendations using the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<RecommendedSymbol>> GetStockRecommendationsAsync(string symbol)
    {
        return new RecommendationHelper().ParseYahooJsonData<RecommendedSymbol>(await DownloadRecommendDataAsync(symbol));
    }

    /// <summary>
    /// Gets key statistics for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<KeyStatistics> GetKeyStatisticsAsync(string symbol)
    {
        return new KeyStatisticsHelper().ParseYahooJsonData<KeyStatistics>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.KeyStatistics)).First();
    }

    /// <summary>
    /// Gets summary details for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<SummaryDetail> GetSummaryDetailsAsync(string symbol)
    {
        return new SummaryDetailsHelper().ParseYahooJsonData<SummaryDetail>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.SummaryDetails)).First();
    }

    /// <summary>
    /// Gets insider holders for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<InsiderHolder>> GetInsiderHoldersAsync(string symbol)
    {
        return new InsiderHolderHelper().ParseYahooJsonData<InsiderHolder>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.InsiderHolders));
    }

    /// <summary>
    /// Gets insider transactions for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Transaction>> GetInsiderTransactionsAsync(string symbol)
    {
        return new InsiderTransactionHelper().ParseYahooJsonData<Transaction>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.InsiderTransactions));
    }

    /// <summary>
    /// Gets financial data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<FinancialData> GetFinancialDataAsync(string symbol)
    {
        return new FinancialDataHelper().ParseYahooJsonData<FinancialData>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.FinancialData)).First();
    }

    /// <summary>
    /// Gets institution ownership data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<OwnershipList>> GetInstitutionOwnershipAsync(string symbol)
    {
        return new InstitutionOwnershipHelper().ParseYahooJsonData<OwnershipList>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.InstitutionOwnership));
    }

    /// <summary>
    /// Gets fund ownership data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<OwnershipList>> GetFundOwnershipAsync(string symbol)
    {
        return new FundOwnershipHelper().ParseYahooJsonData<OwnershipList>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.FundOwnership));
    }

    /// <summary>
    /// Gets major direct holders data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<object>> GetMajorDirectHoldersAsync(string symbol)
    {
        return new MajorDirectHoldersHelper().ParseYahooJsonData<object>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.MajorDirectHolders));
    }
}