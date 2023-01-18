namespace OoplesFinance.YahooFinanceAPI.Models;

public class QuoteTypeQuoteSummary
{
    [JsonPropertyName("result")]
    public List<QuoteTypeResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class QuoteType
{
    [JsonPropertyName("exchange")] 
    public string Exchange { get; set; } = string.Empty;

    [JsonPropertyName("quoteType")] 
    public string QuoteTypeInfo { get; set; } = string.Empty;

    [JsonPropertyName("symbol")] 
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("underlyingSymbol")] 
    public string UnderlyingSymbol { get; set; } = string.Empty;

    [JsonPropertyName("shortName")] 
    public string ShortName { get; set; } = string.Empty;

    [JsonPropertyName("longName")] 
    public string LongName { get; set; } = string.Empty;

    [JsonPropertyName("firstTradeDateEpochUtc")]
    public int? FirstTradeDateEpochUtc { get; set; }

    [JsonPropertyName("timeZoneFullName")] 
    public string TimeZoneFullName { get; set; } = string.Empty;

    [JsonPropertyName("timeZoneShortName")]
    public string TimeZoneShortName { get; set; } = string.Empty;

    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;

    [JsonPropertyName("gmtOffSetMilliseconds")]
    public int? GmtOffSetMilliseconds { get; set; }

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class QuoteTypeResult
{
    [JsonPropertyName("quoteType")]
    public QuoteType QuoteType { get; set; } = new();
}

public class QuoteTypeData
{
    [JsonPropertyName("quoteSummary")]
    public QuoteTypeQuoteSummary QuoteSummary { get; set; } = new();
}