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

    /// <summary>
    /// Gets sec filings data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Filing>> GetSecFilingsAsync(string symbol)
    {
        return new SecFilingsHelper().ParseYahooJsonData<Filing>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.SecFilings));
    }

    /// <summary>
    /// Gets insights data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<InsightsResult> GetInsightsAsync(string symbol)
    {
        return new InsightsHelper().ParseYahooJsonData<InsightsResult>(await DownloadInsightsDataAsync(symbol)).First();
    }

    /// <summary>
    /// Gets major holders breakdown data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<MajorHoldersBreakdown> GetMajorHoldersBreakdownAsync(string symbol)
    {
        return new MajorHoldersBreakdownHelper().ParseYahooJsonData<MajorHoldersBreakdown>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.MajorHoldersBreakdown)).First();
    }

    /// <summary>
    /// Gets upgrade downgrade history data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<History>> GetUpgradeDowngradeHistoryAsync(string symbol)
    {
        return new UpgradeDowngradeHistoryHelper().ParseYahooJsonData<History>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.UpgradeDowngradeHistory));
    }

    /// <summary>
    /// Gets esg scores data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<EsgScores> GetEsgScoresAsync(string symbol)
    {
        return new EsgScoresHelper().ParseYahooJsonData<EsgScores>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.EsgScores)).First();
    }

    /// <summary>
    /// Gets recommendation trend data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Trend>> GetRecommendationTrendAsync(string symbol)
    {
        return new RecommendationTrendHelper().ParseYahooJsonData<Trend>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.RecommendationTrend));
    }

    /// <summary>
    /// Gets index trend data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IndexTrend> GetIndexTrendAsync(string symbol)
    {
        return new IndexTrendHelper().ParseYahooJsonData<IndexTrend>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.IndexTrend)).First();
    }

    /// <summary>
    /// Gets sector trend data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<SectorTrend> GetSectorTrendAsync(string symbol)
    {
        return new SectorTrendHelper().ParseYahooJsonData<SectorTrend>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.SectorTrend)).First();
    }

    /// <summary>
    /// Gets earnings trend data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<EarningsTrendInfo>> GetEarningsTrendAsync(string symbol)
    {
        return new EarningsTrendHelper().ParseYahooJsonData<EarningsTrendInfo>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.EarningsTrend));
    }

    /// <summary>
    /// Gets asset profile data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<AssetProfile> GetAssetProfileAsync(string symbol)
    {
        return new AssetProfileHelper().ParseYahooJsonData<AssetProfile>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.AssetProfile)).First();
    }

    /// <summary>
    /// Gets fund profile data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<FundProfile> GetFundProfileAsync(string symbol)
    {
        return new FundProfileHelper().ParseYahooJsonData<FundProfile>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.FundProfile)).First();
    }

    /// <summary>
    /// Gets calendar events data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<CalendarEvents>> GetCalendarEventsAsync(string symbol)
    {
        return new CalendarEventsHelper().ParseYahooJsonData<CalendarEvents>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.CalendarEvents));
    }

    /// <summary>
    /// Gets earnings data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<EarningsInfo>> GetEarningsAsync(string symbol)
    {
        return new EarningsHelper().ParseYahooJsonData<EarningsInfo>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.Earnings));
    }

    /// <summary>
    /// Gets balance sheet history data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<BalanceSheetStatement>> GetBalanceSheetHistoryAsync(string symbol)
    {
        return new BalanceSheetHistoryHelper().ParseYahooJsonData<BalanceSheetStatement>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.BalanceSheetHistory));
    }

    /// <summary>
    /// Gets cashflow statement history data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<CashflowStatement>> GetCashflowStatementHistoryAsync(string symbol)
    {
        return new CashflowStatementHistoryHelper().ParseYahooJsonData<CashflowStatement>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.CashflowStatementHistory));
    }

    /// <summary>
    /// Gets income statement history data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<IncomeStatementHistory>> GetIncomeStatementHistoryAsync(string symbol)
    {
        return new IncomeStatementHistoryHelper().ParseYahooJsonData<IncomeStatementHistory>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.IncomeStatementHistory));
    }

    /// <summary>
    /// Gets earnings history data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<EarningsHistoryInfo>> GetEarningsHistoryAsync(string symbol)
    {
        return new EarningsHistoryHelper().ParseYahooJsonData<EarningsHistoryInfo>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.EarningsHistory));
    }

    /// <summary>
    /// Gets quote type data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<QuoteType> GetQuoteTypeAsync(string symbol)
    {
        return new QuoteTypeHelper().ParseYahooJsonData<QuoteType>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.QuoteType)).First();
    }

    /// <summary>
    /// Gets price data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<Price> GetPriceInfoAsync(string symbol)
    {
        return new PriceHelper().ParseYahooJsonData<Price>(await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.Price)).First();
    }

    /// <summary>
    /// Gets net share purchase activity data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<NetSharePurchaseActivity> GetNetSharePurchaseActivityAsync(string symbol)
    {
        return new NetSharePurchaseActivityHelper().ParseYahooJsonData<NetSharePurchaseActivity>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.NetSharePurchaseActivity)).First();
    }

    /// <summary>
    /// Gets income statement history quarterly data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<IncomeStatementHistoryItem>> GetIncomeStatementHistoryQuarterlyAsync(string symbol)
    {
        return new IncomeStatementHistoryQuarterlyHelper().ParseYahooJsonData<IncomeStatementHistoryItem>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.IncomeStatementHistoryQuarterly));
    }

    /// <summary>
    /// Gets cashflow statement history quarterly data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<CashflowStatement>> GetCashflowStatementHistoryQuarterlyAsync(string symbol)
    {
        return new CashflowStatementHistoryQuarterlyHelper().ParseYahooJsonData<CashflowStatement>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.CashflowStatementHistoryQuarterly));
    }

    /// <summary>
    /// Gets balance sheet history quarterly data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<IEnumerable<BalanceSheetStatement>> GetBalanceSheetHistoryQuarterlyAsync(string symbol)
    {
        return new BalanceSheetHistoryQuarterlyHelper().ParseYahooJsonData<BalanceSheetStatement>(
            await DownloadStatsDataAsync(symbol, Country, Language, YahooModule.BalanceSheetHistoryQuarterly));
    }

    /// <summary>
    /// Gets chart info data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="timeRange"></param>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    public async Task<IEnumerable<ChartResult>> GetChartInfoAsync(string symbol, TimeRange timeRange, TimeInterval timeInterval)
    {
        return new ChartHelper().ParseYahooJsonData<ChartResult>(await DownloadChartDataAsync(symbol, timeRange, timeInterval));
    }

    /// <summary>
    /// Gets spark chart info data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="timeRange"></param>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    public async Task<SparkInfo> GetSparkChartInfoAsync(string symbol, TimeRange timeRange, TimeInterval timeInterval)
    {
        return new SparkChartHelper().ParseYahooJsonData<SparkInfo>(await DownloadSparkChartDataAsync(symbol, timeRange, timeInterval)).First();
    }

    /// <summary>
    /// Gets spark chart info data for the selected stock symbols
    /// </summary>
    /// <param name="symbols"></param>
    /// <param name="timeRange"></param>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    public async Task<IEnumerable<SparkInfo>> GetSparkChartInfoAsync(IEnumerable<string> symbols, TimeRange timeRange, TimeInterval timeInterval)
    {
        return new SparkChartHelper().ParseYahooJsonData<SparkInfo>(await DownloadSparkChartDataAsync(symbols, timeRange, timeInterval));
    }

    /// <summary>
    /// Gets real-time quote data for the selected stock symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public async Task<RealTimeQuoteResult> GetRealTimeQuotesAsync(string symbol)
    {
        return new RealTimeQuoteHelper().ParseYahooJsonData<RealTimeQuoteResult>(await DownloadRealTimeQuoteDataAsync(symbol, Country, Language)).First();
    }

    /// <summary>
    /// Gets real-time quote data for the selected stock symbols
    /// </summary>
    /// <param name="symbols"></param>
    /// <returns></returns>
    public async Task<IEnumerable<RealTimeQuoteResult>> GetRealTimeQuotesAsync(IEnumerable<string> symbols)
    {
        return new RealTimeQuoteHelper().ParseYahooJsonData<RealTimeQuoteResult>(await DownloadRealTimeQuoteDataAsync(symbols, Country, Language));
    }
}