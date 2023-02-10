namespace OoplesFinance.YahooFinanceAPI.Models;

public class RecommendFinance
{
    [JsonProperty("result")]
    public List<RecommendResult> Results { get; set; } = new();

    [JsonProperty("error")]
    public object Error { get; set; } = new();
}

public class RecommendedSymbol
{
    [JsonProperty("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonProperty("score")]
    public double Score { get; set; }
}

public class RecommendResult
{
    [JsonProperty("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonProperty("recommendedSymbols")]
    public List<RecommendedSymbol> RecommendedSymbols { get; set; } = new();
}

public class RecommendData
{
    [JsonProperty("finance")]
    public RecommendFinance Finance { get; set; } = new();
}