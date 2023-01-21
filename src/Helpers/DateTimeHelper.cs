namespace OoplesFinance.YahooFinanceAPI.Helpers;

public static class DateTimeHelper
{
    /// <summary>
    /// Converts a date to the Unix format which is the amount of seconds since Jan 1, 1970
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static long ToUnixTimestamp(this DateTime dateTime)
    {
        return new DateTimeOffset(dateTime).ToUnixTimeSeconds();
    }

    /// <summary>
    /// Converts a data from the Unix format which is the amount of seconds since Jan 1, 1970 to a normal date
    /// </summary>
    /// <param name="unixTimestamp"></param>
    /// <returns></returns>
    public static DateTime FromUnixTimeStamp(this long unixTimestamp)
    {
        return DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).DateTime;
    }
}
