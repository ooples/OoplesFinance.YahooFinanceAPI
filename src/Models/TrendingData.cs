namespace OoplesFinance.YahooFinanceAPI.Models;

internal class TrendingFinance
{
    [JsonProperty("result")]
    public List<TrendingResult> Results { get; set; } = [];

    [JsonProperty("error")]
    public object Error { get; set; } = new();
}

internal class TrendingQuote
{
    [JsonProperty("symbol")]
    public string Symbol { get; set; } = string.Empty;
}

internal class TrendingResult
{
    [JsonProperty("count")]
    public int? Count { get; set; }

    [JsonProperty("quotes")]
    public List<TrendingQuote> Quotes { get; set; } = [];

    [JsonProperty("jobTimestamp")]
    public long? JobTimestamp { get; set; }

    [JsonProperty("startInterval")]
    public long? StartInterval { get; set; }
}

internal class TrendingData
{
    [JsonProperty("finance")]
    public TrendingFinance Finance { get; set; } = new();
}