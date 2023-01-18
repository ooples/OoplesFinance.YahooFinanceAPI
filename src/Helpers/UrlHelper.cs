using OoplesFinance.YahooFinanceAPI.Enums;
using System.Reflection;

namespace OoplesFinance.YahooFinanceAPI.Helpers;

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
    internal static Uri BuildYahooCsvUrl(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate, bool includeAdjClose) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v7/finance/download/{symbol}?period1={startDate.ToUnixTimestamp()}" +
            $"&period2={(endDate ?? DateTime.Now).ToUnixTimestamp()}&interval={GetIntervalString(dataFrequency)}&events={GetEventsString(dataType)}&includeAdjustedClose={includeAdjClose}"));

    /// <summary>
    /// Creates a url that will be used to get the top trending stocks using the chosen parameters
    /// </summary>
    /// <param name="country"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    internal static Uri BuildYahooTrendingUrl(Country country, int count) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query2.finance.yahoo.com/v1/finance/trending/{GetCountryString(country)}?count={count}"));

    /// <summary>
    /// Creates a url that will be used to get recommendations for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    internal static Uri BuildYahooRecommendUrl(string symbol) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query2.finance.yahoo.com/v6/finance/recommendationsbysymbol/{symbol}"));

    /// <summary>
    /// Creates a url that will be used to get insights for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    internal static Uri BuildYahooInsightsUrl(string symbol) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/ws/insights/v1/finance/insights?symbol={symbol}"));

    /// <summary>
    /// Creates a url that will be used to get stats for a selected symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="language"></param>
    /// <param name="country"></param>
    /// <param name="module"></param>
    /// <returns></returns>
    internal static Uri BuildYahooStatsUrl(string symbol, Country country, Language language, YahooModule module) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v11/finance/quoteSummary/{symbol}?lang={GetLanguageString(language)}" +
            $"&region={GetCountryString(country)}&modules={GetModuleString(module)}"));

    /// <summary>
    /// Returns a custom string for the module option
    /// </summary>
    /// <param name="module"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private static string GetModuleString(YahooModule module) =>
        module switch
        {
            YahooModule.AssetProfile             => "assetProfile",
            YahooModule.BalanceSheetHistory      => "balanceSheetHistory",
            YahooModule.CalendarEvents           => "calendarEvents",
            YahooModule.CashflowStatementHistory => "cashflowStatementHistory",
            YahooModule.Earnings                 => "earnings",
            YahooModule.EarningsHistory          => "earningsHistory",
            YahooModule.EarningsTrend            => "earningsTrend",
            YahooModule.EsgScores                => "esgScores",
            YahooModule.FinancialData            => "financialData",
            YahooModule.FundOwnership            => "fundOwnership",
            YahooModule.FundProfile              => "fundProfile",
            YahooModule.IncomeStatementHistory   => "incomeStatementHistory",
            YahooModule.IndexTrend               => "indexTrend",
            YahooModule.InsiderHolders           => "insiderHolders",
            YahooModule.InsiderTransactions      => "insiderTransactions",
            YahooModule.InstitutionOwnership     => "institutionOwnership",
            YahooModule.KeyStatistics            => "defaultKeyStatistics",
            YahooModule.MajorDirectHolders       => "majorDirectHolders",
            YahooModule.MajorHoldersBreakdown    => "majorHoldersBreakdown",
            YahooModule.NetSharePurchaseActivity => "netSharePurchaseActivity",
            YahooModule.Price                    => "price",
            YahooModule.QuoteType                => "quoteType",
            YahooModule.RecommendationTrend      => "recommendationTrend",
            YahooModule.SecFilings               => "secFilings",
            YahooModule.SectorTrend              => "sectorTrend",
            YahooModule.SummaryDetails           => "summaryDetail",
            YahooModule.UpgradeDowngradeHistory  => "upgradeDowngradeHistory",
            _                                    => throw new ArgumentException("Invalid Enumerator Value", nameof(module))
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
    /// Returns a custom string for the Data Frequency option.
    /// </summary>
    /// <param name="dataFrequency"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators.</exception>
    private static string GetIntervalString(DataFrequency dataFrequency) =>
        dataFrequency switch
        {
            DataFrequency.Daily   => "1d",
            DataFrequency.Weekly  => "1wk",
            DataFrequency.Monthly => "1mo",
            _                     => throw new ArgumentException("Invalid Enumerator Value", nameof(dataFrequency))
        };

    /// <summary>
    /// Returns a custom string for the Data Type option.
    /// </summary>
    /// <param name="dataType"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws an exception if the enumerator isn't in the list of available enumerators.</exception>
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
