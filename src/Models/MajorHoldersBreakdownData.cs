namespace OoplesFinance.YahooFinanceAPI.Models;

public class InsidersPercentHeld
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class InstitutionsCount
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class InstitutionsFloatPercentHeld
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class InstitutionsPercentHeld
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class MajorHoldersBreakdown
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("insidersPercentHeld")] 
    public InsidersPercentHeld InsidersPercentHeld { get; set; } = new();

    [JsonPropertyName("institutionsPercentHeld")] 
    public InstitutionsPercentHeld InstitutionsPercentHeld { get; set; } = new();

    [JsonPropertyName("institutionsFloatPercentHeld")] 
    public InstitutionsFloatPercentHeld InstitutionsFloatPercentHeld { get; set; } = new();

    [JsonPropertyName("institutionsCount")]
    public InstitutionsCount InstitutionsCount { get; set; } = new();
}

public class MajorHoldersBreakdownQuoteSummary
{
    [JsonPropertyName("result")]
    public List<MajorHoldersBreakdownResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class MajorHoldersBreakdownResult
{
    [JsonPropertyName("majorHoldersBreakdown")] 
    public MajorHoldersBreakdown MajorHoldersBreakdown { get; set; } = new();
}

public class MajorHoldersBreakdownData
{
    [JsonPropertyName("quoteSummary")] 
    public MajorHoldersBreakdownQuoteSummary QuoteSummary { get; set; } = new();
}