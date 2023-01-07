namespace OoplesFinance.YahooFinanceAPI.Helpers;

public static class DateTimeHelper
{
    /// <summary>
    /// Yahoo Finance requires all dates to be in the Unix format which is the amount of seconds since Jan 1, 1970
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static long ToUnixTimestamp(this DateTime dateTime)
    {
        return new DateTimeOffset(dateTime).ToUnixTimeSeconds();
    }
}
