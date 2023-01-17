namespace OoplesFinance.YahooFinanceAPI.Models;

public class RecommendationTrendQuoteSummary
{
    [JsonPropertyName("result")]
    public List<RecommendationTrendResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class RecommendationTrend
{
    [JsonPropertyName("trend")] 
    public List<Trend> Trend { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class RecommendationTrendResult
{
    [JsonPropertyName("recommendationTrend")]
    public RecommendationTrend RecommendationTrend { get; set; } = new();
}

public class RecommendationTrendData
{
    [JsonPropertyName("quoteSummary")]
    public RecommendationTrendQuoteSummary QuoteSummary { get; set; } = new();
}

public class Trend
{
    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("strongBuy")]
    public int? StrongBuy { get; set; }

    [JsonPropertyName("buy")]
    public int? Buy { get; set; }

    [JsonPropertyName("hold")]
    public int? Hold { get; set; }

    [JsonPropertyName("sell")]
    public int? Sell { get; set; }

    [JsonPropertyName("strongSell")]
    public int? StrongSell { get; set; }
}