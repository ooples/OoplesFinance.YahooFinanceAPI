namespace OoplesFinance.YahooFinanceAPI.Models;

internal class Finance
{
    [JsonPropertyName("result")]
    public List<Result> Result { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

internal class Quote
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;
}

internal class Result
{
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("quotes")]
    public List<Quote> Quotes { get; set; } = new();

    [JsonPropertyName("jobTimestamp")]
    public long? JobTimestamp { get; set; }

    [JsonPropertyName("startInterval")]
    public long? StartInterval { get; set; }
}

internal class TrendingData
{
    [JsonPropertyName("finance")]
    public Finance Finance { get; set; } = new();
}