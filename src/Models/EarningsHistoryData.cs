namespace OoplesFinance.YahooFinanceAPI.Models;

public class EarningsHistory
{
    [JsonPropertyName("history")]
    public List<EarningsHistoryInfo> History { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class EpsActual
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EpsDifference
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EpsEstimate
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EarningsHistoryInfo
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("epsActual")] 
    public EpsActual EpsActual { get; set; } = new();

    [JsonPropertyName("epsEstimate")] 
    public EpsEstimate EpsEstimate { get; set; } = new();

    [JsonPropertyName("epsDifference")] 
    public EpsDifference EpsDifference { get; set; } = new();

    [JsonPropertyName("surprisePercent")]
    public SurprisePercent SurprisePercent { get; set; } = new();

    [JsonPropertyName("quarter")]
    public Quarter Quarter { get; set; } = new();

    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;
}

public class Quarter
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EarningsHistoryQuoteSummary
{
    [JsonPropertyName("result")]
    public List<EarningsHistoryResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class EarningsHistoryResult
{
    [JsonPropertyName("earningsHistory")] 
    public EarningsHistory EarningsHistory { get; set; } = new();
}

public class EarningsHistoryData
{
    [JsonPropertyName("quoteSummary")] 
    public EarningsHistoryQuoteSummary QuoteSummary { get; set; } = new();
}

public class SurprisePercent
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}