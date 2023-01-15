namespace OoplesFinance.YahooFinanceAPI.Models;

public class FundOwnership
{
    [JsonPropertyName("ownershipList")] 
    public List<OwnershipList> OwnershipList { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class FundOwnershipQuoteSummary
{
    [JsonPropertyName("result")]
    public List<FundOwnershipResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class FundOwnershipResult
{
    [JsonPropertyName("fundOwnership")]
    public FundOwnership FundOwnership { get; set; } = new();
}

public class FundOwnershipData
{
    [JsonPropertyName("quoteSummary")] 
    public FundOwnershipQuoteSummary QuoteSummary { get; set; } = new();
}