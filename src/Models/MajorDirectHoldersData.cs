namespace OoplesFinance.YahooFinanceAPI.Models;

public class MajorDirectHolders
{
    [JsonPropertyName("holders")]
    public List<object> Holders { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class MajorDirectHoldersQuoteSummary
{
    [JsonPropertyName("result")]
    public List<MajorDirectHoldersResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class MajorDirectHoldersResult
{
    [JsonPropertyName("majorDirectHolders")] 
    public MajorDirectHolders MajorDirectHolders { get; set; } = new();
}

public class MajorDirectHoldersData
{
    [JsonPropertyName("quoteSummary")] 
    public MajorDirectHoldersQuoteSummary QuoteSummary { get; set; } = new();
}