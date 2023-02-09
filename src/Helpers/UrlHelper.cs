﻿namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal static class UrlHelper
{

    /// <summary>
    /// Creates a url that will be used to compile the chosen parameter options into a csv file.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataType"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjClose"></param>
    /// <returns></returns>
    internal static string BuildYahooCsvUrl(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate, bool includeAdjClose) => 
        string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v7/finance/download/{symbol}?period1={startDate.ToUnixTimestamp()}" +
            $"&period2={(endDate ?? DateTime.Now).ToUnixTimestamp()}&interval={GetFrequencyString(dataFrequency)}&events={GetEventsString(dataType)}" +
            $"&includeAdjustedClose={includeAdjClose}");

    /// <summary>
    /// Creates a url that will be used to get the top trending stocks using the chosen parameters
    /// </summary>
    /// <param name="country"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    internal static string BuildYahooTrendingUrl(Country country, int count) => 
        string.Format(CultureInfo.InvariantCulture, $"https://query2.finance.yahoo.com/v1/finance/trending/{GetCountryString(country)}?count={count}");

    /// <summary>
    /// Creates a url that will be used to get recommendations for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    internal static string BuildYahooRecommendUrl(string symbol) =>
        string.Format(CultureInfo.InvariantCulture, $"https://query2.finance.yahoo.com/v6/finance/recommendationsbysymbol/{symbol}");

    /// <summary>
    /// Creates a url that will be used to get insights for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    internal static string BuildYahooInsightsUrl(string symbol) =>
        string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/ws/insights/v1/finance/insights?symbol={symbol}");

    /// <summary>
    /// Creates a url that will be used to get the market summary
    /// </summary>
    /// <param name="country"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    internal static string BuildYahooMarketSummaryUrl(Country country, Language language) =>
        string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v6/finance/quote/marketSummary?" +
            $"lang={GetLanguageString(language)}&region={GetCountryString(country)}");

    /// <summary>
    /// Creates a url that will be used to get chart data for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    internal static string BuildYahooChartUrl(string symbol, TimeRange timeRange, TimeInterval timeInterval) =>
        string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v8/finance/chart/{symbol}?" +
            $"range={GetTimeRangeString(timeRange)}&interval={GetTimeIntervalString(timeInterval)}");

    /// <summary>
    /// Creates a url that will be used to get spark chart data for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="timeRange"></param>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    internal static string BuildYahooSparkChartUrl(IEnumerable<string> symbols, TimeRange timeRange, TimeInterval timeInterval) =>
        string.Format(CultureInfo.InvariantCulture, $"https://query2.finance.yahoo.com/v8/finance/spark?interval=" +
            $"{GetTimeIntervalString(timeInterval)}&range={GetTimeRangeString(timeRange)}&symbols={GetSymbolsString(symbols)}");

    /// <summary>
    /// Creates a url that will be used to get stats for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="language"></param>
    /// <param name="country"></param>
    /// <param name="module"></param>
    /// <returns></returns>
    internal static string BuildYahooStatsUrl(string symbol, Country country, Language language, YahooModule module) =>
        string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v11/finance/quoteSummary/{symbol}?lang={GetLanguageString(language)}" +
            $"&region={GetCountryString(country)}&modules={GetModuleString(module)}");

    /// <summary>
    /// Creates a url that will be used to get real-time quotes for multiple symbols
    /// </summary>
    /// <param name="symbolsList"></param>
    /// <param name="country"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    internal static string BuildYahooRealTimeQuoteUrl(IEnumerable<string> symbols, Country country, Language language) =>
        string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v6/finance/quote?region=" +
            $"{GetCountryString(country)}&lang={GetLanguageString(language)}&symbols={GetSymbolsString(symbols)}");

    /// <summary>
    /// Returns a custom string for the symbols option
    /// </summary>
    /// <param name="symbolsList"></param>
    /// <returns></returns>
    private static string GetSymbolsString(IEnumerable<string> symbols)
    {
        var result = string.Empty;
        var comma = Uri.EscapeDataString(",");
        for (int i = 0; i < symbols.Count(); i++)
        {
            var symbol = symbols.ElementAt(i);
            // if it isn't the first element then add the encoded comma before the symbol
            result += i != 0 ? comma + symbol : symbol;
        }

        return result;
    }

    /// <summary>
    /// Returns a custom string for the module option
    /// </summary>
    /// <param name="module"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private static string GetModuleString(YahooModule module) =>
        module switch
        {
            YahooModule.AssetProfile                      => "assetProfile",
            YahooModule.BalanceSheetHistory               => "balanceSheetHistory",
            YahooModule.BalanceSheetHistoryQuarterly      => "balanceSheetHistoryQuarterly",
            YahooModule.CalendarEvents                    => "calendarEvents",
            YahooModule.CashflowStatementHistory          => "cashflowStatementHistory",
            YahooModule.CashflowStatementHistoryQuarterly => "cashflowStatementHistoryQuarterly",
            YahooModule.Earnings                          => "earnings",
            YahooModule.EarningsHistory                   => "earningsHistory",
            YahooModule.EarningsTrend                     => "earningsTrend",
            YahooModule.EsgScores                         => "esgScores",
            YahooModule.FinancialData                     => "financialData",
            YahooModule.FundOwnership                     => "fundOwnership",
            YahooModule.FundProfile                       => "fundProfile",
            YahooModule.IncomeStatementHistory            => "incomeStatementHistory",
            YahooModule.IncomeStatementHistoryQuarterly   => "incomeStatementHistoryQuarterly",
            YahooModule.IndexTrend                        => "indexTrend",
            YahooModule.InsiderHolders                    => "insiderHolders",
            YahooModule.InsiderTransactions               => "insiderTransactions",
            YahooModule.InstitutionOwnership              => "institutionOwnership",
            YahooModule.KeyStatistics                     => "defaultKeyStatistics",
            YahooModule.MajorDirectHolders                => "majorDirectHolders",
            YahooModule.MajorHoldersBreakdown             => "majorHoldersBreakdown",
            YahooModule.NetSharePurchaseActivity          => "netSharePurchaseActivity",
            YahooModule.Price                             => "price",
            YahooModule.QuoteType                         => "quoteType",
            YahooModule.RecommendationTrend               => "recommendationTrend",
            YahooModule.SecFilings                        => "secFilings",
            YahooModule.SectorTrend                       => "sectorTrend",
            YahooModule.SummaryDetails                    => "summaryDetail",
            YahooModule.UpgradeDowngradeHistory           => "upgradeDowngradeHistory",
            _                                             => throw new ArgumentException("Invalid Enumerator Value", nameof(module))
        };

    /// <summary>
    /// Returns a custom string for the Language option
    /// </summary>
    /// <param name="language"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private static string GetLanguageString(Language language) =>
        language switch
        {
            Language.English  => "en",
            Language.French   => "fr",
            Language.German   => "de",
            Language.Italian  => "it",
            Language.Mandarin => "zh",
            Language.Spanish  => "es",
            _                 => throw new ArgumentException("Invalid Enumerator Value", nameof(language))
        };

    /// <summary>
    /// Returns a custom string for the Country option
    /// </summary>
    /// <param name="country"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private static string GetCountryString(Country country) =>
        country switch
        {
            Country.UnitedStates  => "US",
            Country.Australia     => "AU",
            Country.Canada        => "CA",
            Country.France        => "FR",
            Country.Germany       => "DE",
            Country.HongKong      => "HK",
            Country.India         => "IN",
            Country.Italy         => "IT",
            Country.Spain         => "ES",
            Country.UnitedKingdom => "GB",
            _                     => throw new ArgumentException("Invalid Enumerator Value", nameof(country))
        };

    /// <summary>
    /// Returns a custom string for the Data Frequency option
    /// </summary>
    /// <param name="dataFrequency"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators</exception>
    private static string GetFrequencyString(DataFrequency dataFrequency) =>
        dataFrequency switch
        {
            DataFrequency.Daily   => "1d",
            DataFrequency.Weekly  => "1wk",
            DataFrequency.Monthly => "1mo",
            _                     => throw new ArgumentException("Invalid Enumerator Value", nameof(dataFrequency))
        };

    /// <summary>
    /// Returns a custom string for the Time Interval option
    /// </summary>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators</exception>
    private static string GetTimeIntervalString(TimeInterval timeInterval) =>
        timeInterval switch
        {
            TimeInterval._1Minute   => "1m",
            TimeInterval._2Minutes  => "2m",
            TimeInterval._5Minutes  => "5m",
            TimeInterval._15Minutes => "15m",
            TimeInterval._30Minutes => "30m",
            TimeInterval._60Minutes => "60m",
            TimeInterval._90Minutes => "90m",
            TimeInterval._1Hour     => "1h",
            TimeInterval._1Day      => "1d",
            TimeInterval._5Days     => "5d",
            TimeInterval._1Week     => "1wk",
            TimeInterval._1Month    => "1mo",
            TimeInterval._3Months   => "3mo",
            _                       => throw new ArgumentException("Invalid Enumerator Value", nameof(timeInterval))
        };

    /// <summary>
    /// Returns a custom string for the Time Range option
    /// </summary>
    /// <param name="timeRange"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators</exception>
    private static string GetTimeRangeString(TimeRange timeRange) =>
        timeRange switch
        {
            TimeRange._1Day      => "1d",
            TimeRange._5Days     => "5d",
            TimeRange._1Month    => "1mo",
            TimeRange._3Months   => "3mo",
            TimeRange._6Months   => "6mo",
            TimeRange._1Year     => "1y",
            TimeRange._2Years    => "2y",
            TimeRange._5Years    => "5y",
            TimeRange._10Years   => "10y",
            TimeRange.YearToDate => "ytd",
            TimeRange.Max        => "max",
            _                    => throw new ArgumentException("Invalid Enumerator Value", nameof(timeRange))
        };

    /// <summary>
    /// Returns a custom string for the Data Type option
    /// </summary>
    /// <param name="dataType"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators</exception>
    private static string GetEventsString(DataType dataType) =>
        dataType switch
        {
            DataType.HistoricalPrices => "history",
            DataType.Dividends        => "div",
            DataType.StockSplits      => "split",
            DataType.CapitalGains     => "capitalGain",
            _                         => throw new ArgumentException("Invalid Enumerator Value", nameof(dataType))
        };
}