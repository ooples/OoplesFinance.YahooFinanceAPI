namespace OoplesFinance.YahooFinanceAPI.Models;

public class _30daysAgo
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class _60daysAgo
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class _7daysAgo
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class _90daysAgo
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class Avg
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class Current
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class DownLast30days
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class DownLast90days
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class EarningsEstimate
{
    [JsonPropertyName("avg")] 
    public Avg Avg { get; set; } = new();

    [JsonPropertyName("low")]
    public Low Low { get; set; } = new();

    [JsonPropertyName("high")] 
    public High High { get; set; } = new();

    [JsonPropertyName("yearAgoEps")] 
    public YearAgoEps YearAgoEps { get; set; } = new();

    [JsonPropertyName("numberOfAnalysts")] 
    public NumberOfAnalysts NumberOfAnalysts { get; set; } = new();

    [JsonPropertyName("growth")] 
    public Growth Growth { get; set; } = new();
}

public class EarningsTrend
{
    [JsonPropertyName("trend")]
    public List<EarningsTrendInfo> Trends { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class EpsRevisions
{
    [JsonPropertyName("upLast7days")] 
    public UpLast7days UpLast7days { get; set; } = new();

    [JsonPropertyName("upLast30days")] 
    public UpLast30days UpLast30days { get; set; } = new();

    [JsonPropertyName("downLast30days")] 
    public DownLast30days DownLast30days { get; set; } = new();

    [JsonPropertyName("downLast90days")] 
    public DownLast90days DownLast90days { get; set; } = new();
}

public class EpsTrend
{
    [JsonPropertyName("current")] 
    public Current Current { get; set; } = new();

    [JsonPropertyName("7daysAgo")] 
    public _7daysAgo _7daysAgo { get; set; } = new();

    [JsonPropertyName("30daysAgo")] 
    public _30daysAgo _30daysAgo { get; set; } = new();

    [JsonPropertyName("60daysAgo")]
    public _60daysAgo _60daysAgo { get; set; } = new();

    [JsonPropertyName("90daysAgo")]
    public _90daysAgo _90daysAgo { get; set; } = new();
}

public class High
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class Low
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NumberOfAnalysts
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class EarningsTrendQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<EarningsTrendResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class EarningsTrendResult
{
    [JsonPropertyName("earningsTrend")] 
    public EarningsTrend EarningsTrend { get; set; } = new();
}

public class RevenueEstimate
{
    [JsonPropertyName("avg")] 
    public Avg Avg { get; set; } = new();

    [JsonPropertyName("low")] 
    public Low Low { get; set; } = new();

    [JsonPropertyName("high")] 
    public High High { get; set; } = new();

    [JsonPropertyName("numberOfAnalysts")] 
    public NumberOfAnalysts NumberOfAnalysts { get; set; } = new();

    [JsonPropertyName("yearAgoRevenue")]
    public YearAgoRevenue YearAgoRevenue { get; set; } = new();

    [JsonPropertyName("growth")]
    public Growth Growth { get; set; } = new();
}

public class EarningsTrendData
{
    [JsonPropertyName("quoteSummary")]
    public EarningsTrendQuoteSummary QuoteSummary { get; set; } = new();
}

public class EarningsTrendInfo
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("endDate")]
    public string EndDate { get; set; } = string.Empty;

    [JsonPropertyName("growth")] 
    public Growth Growth { get; set; } = new();

    [JsonPropertyName("earningsEstimate")] 
    public EarningsEstimate EarningsEstimate { get; set; } = new();

    [JsonPropertyName("revenueEstimate")] 
    public RevenueEstimate RevenueEstimate { get; set; } = new();

    [JsonPropertyName("epsTrend")]
    public EpsTrend EpsTrend { get; set; } = new();

    [JsonPropertyName("epsRevisions")]
    public EpsRevisions EpsRevisions { get; set; } = new();
}

public class UpLast30days
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class UpLast7days
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class YearAgoEps
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class YearAgoRevenue
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}