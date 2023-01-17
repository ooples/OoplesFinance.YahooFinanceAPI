namespace OoplesFinance.YahooFinanceAPI.Models;

public class Estimate
{
    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("growth")]
    public Growth Growth { get; set; } = new();
}

public class Growth
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class IndexTrend
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("peRatio")] 
    public PeRatio PeRatio { get; set; } = new();

    [JsonPropertyName("pegRatio")]
    public PegRatio PegRatio { get; set; } = new();

    [JsonPropertyName("estimates")]
    public List<Estimate> Estimates { get; set; } = new();
}

public class PeRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class IndexTrendQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<IndexTrendResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class IndexTrendResult
{
    [JsonPropertyName("indexTrend")]
    public IndexTrend IndexTrend { get; set; } = new();
}

public class IndexTrendData
{
    [JsonPropertyName("quoteSummary")]
    public IndexTrendQuoteSummary QuoteSummary { get; set; } = new();
}