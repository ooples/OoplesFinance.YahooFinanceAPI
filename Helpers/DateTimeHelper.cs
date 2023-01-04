namespace OoplesFinance.YahooFinanceAPI.Helpers;

public static class DateTimeHelper
{
    public static long ToUnixTimestamp(this DateTime dateTime)
    {
        return new DateTimeOffset(dateTime).ToUnixTimeSeconds();
    }
}
