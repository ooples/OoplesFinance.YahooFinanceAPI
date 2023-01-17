namespace OoplesFinance.YahooFinanceAPI.Models;

public class History
{
    [JsonPropertyName("epochGradeDate")]
    public int? EpochGradeDate { get; set; }

    [JsonPropertyName("firm")] 
    public string Firm { get; set; } = string.Empty;

    [JsonPropertyName("toGrade")]
    public string ToGrade { get; set; } = string.Empty;

    [JsonPropertyName("fromGrade")]
    public string FromGrade { get; set; } = string.Empty;

    [JsonPropertyName("action")]
    public string Action { get; set; } = string.Empty;
}

public class UpgradeDowngradeHistoryQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<Result> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class Result
{
    [JsonPropertyName("upgradeDowngradeHistory")] 
    public UpgradeDowngradeHistory UpgradeDowngradeHistory { get; set; } = new();
}

public class UpgradeDowngradeHistoryData
{
    [JsonPropertyName("quoteSummary")]
    public UpgradeDowngradeHistoryQuoteSummary QuoteSummary { get; set; } = new();
}

public class UpgradeDowngradeHistory
{
    [JsonPropertyName("history")]
    public List<History> History { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}