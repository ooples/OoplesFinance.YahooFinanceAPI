namespace OoplesFinance.YahooFinanceAPI.Models;

public class SectorTrendQuoteSummary
{
    [JsonPropertyName("result")]
    public List<SectorTrendResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class SectorTrendResult
{
    [JsonPropertyName("sectorTrend")] 
    public SectorTrend SectorTrend { get; set; } = new();
}

public class SectorTrendData
{
    [JsonPropertyName("quoteSummary")] 
    public SectorTrendQuoteSummary QuoteSummary { get; set; } = new();
}

public class SectorTrend
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("symbol")] 
    public object Symbol { get; set; } = new();

    [JsonPropertyName("peRatio")] 
    public PeRatio PeRatio { get; set; } = new();

    [JsonPropertyName("pegRatio")] 
    public PegRatio PegRatio { get; set; } = new();

    [JsonPropertyName("estimates")] 
    public List<object> Estimates { get; set; } = new();
}