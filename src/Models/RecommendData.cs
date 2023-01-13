namespace OoplesFinance.YahooFinanceAPI.Models;

public class RecommendFinance
{
    [JsonPropertyName("result")]
    public List<RecommendResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class RecommendedSymbol
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("score")]
    public double Score { get; set; }
}

public class RecommendResult
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("recommendedSymbols")]
    public List<RecommendedSymbol> RecommendedSymbols { get; set; } = new();
}

public class RecommendData
{
    [JsonPropertyName("finance")]
    public RecommendFinance Finance { get; set; } = new();
}