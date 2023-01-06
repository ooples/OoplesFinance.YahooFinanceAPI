namespace OoplesFinance.YahooFinanceAPI.Helpers;

public static class DownloadHelper
{
    internal static Uri BuildYahooUrl(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjClose = true) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v7/finance/download/{symbol}?period1={startDate.ToUnixTimestamp()}" +
            $"&period2={(endDate ?? DateTime.Now).ToUnixTimestamp()}&interval={GetIntervalString(dataFrequency)}&events={GetEventsString(dataType)}&includeAdjustedClose={includeAdjClose}"));

    private static string GetIntervalString(DataFrequency dataFrequency) =>
        dataFrequency switch
        {
            DataFrequency.Daily => "1d",
            DataFrequency.Weekly => "1wk",
            DataFrequency.Monthly => "1mo",
            _ => throw new ArgumentException("Invalid Enumerator Value", nameof(dataFrequency))
        };

    private static string GetEventsString(DataType dataType) =>
        dataType switch
        {
            DataType.HistoricalPrices => "history",
            DataType.Dividends => "div",
            DataType.StockSplits => "split",
            DataType.CapitalGains => "capitalGain",
            _ => throw new ArgumentException("Invalid Enumerator Value", nameof(dataType))
        };
}