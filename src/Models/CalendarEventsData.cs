namespace OoplesFinance.YahooFinanceAPI.Models;

public class CalendarEvents
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("earnings")]
    public Earnings Earnings { get; set; } = new();

    [JsonPropertyName("exDividendDate")]
    public ExDividendDate ExDividendDate { get; set; } = new();

    [JsonPropertyName("dividendDate")] 
    public DividendDate DividendDate { get; set; } = new();
}

public class DividendDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class Earnings
{
    [JsonPropertyName("earningsDate")]
    public List<EarningsDate> EarningsDate { get; set; } = new();

    [JsonPropertyName("earningsAverage")] 
    public EarningsAverage EarningsAverage { get; set; } = new();

    [JsonPropertyName("earningsLow")] 
    public EarningsLow EarningsLow { get; set; } = new();

    [JsonPropertyName("earningsHigh")] 
    public EarningsHigh EarningsHigh { get; set; } = new();

    [JsonPropertyName("revenueAverage")]
    public RevenueAverage RevenueAverage { get; set; } = new();

    [JsonPropertyName("revenueLow")]
    public RevenueLow RevenueLow { get; set; } = new();

    [JsonPropertyName("revenueHigh")]
    public RevenueHigh RevenueHigh { get; set; } = new();
}

public class EarningsAverage
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EarningsDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EarningsHigh
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EarningsLow
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class CalendarEventsQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<CalendarEventsResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class CalendarEventsResult
{
    [JsonPropertyName("calendarEvents")]
    public CalendarEvents CalendarEvents { get; set; } = new();
}

public class RevenueAverage
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class RevenueHigh
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class RevenueLow
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class CalendarEventsData
{
    [JsonPropertyName("quoteSummary")]
    public CalendarEventsQuoteSummary QuoteSummary { get; set; } = new();
}