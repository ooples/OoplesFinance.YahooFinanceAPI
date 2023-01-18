namespace OoplesFinance.YahooFinanceAPI.Models;

public class BalanceSheetHistoryQuarterly
{
    [JsonPropertyName("balanceSheetStatements")]
    public List<BalanceSheetStatement> BalanceSheetStatements { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class BalanceSheetHistoryQuarterlyQuoteSummary
{
    [JsonPropertyName("result")]
    public List<BalanceSheetHistoryQuarterlyResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class BalanceSheetHistoryQuarterlyResult
{
    [JsonPropertyName("balanceSheetHistoryQuarterly")] 
    public BalanceSheetHistoryQuarterly BalanceSheetHistoryQuarterly { get; set; } = new();
}

public class BalanceSheetHistoryQuarterlyData
{
    [JsonPropertyName("quoteSummary")] 
    public BalanceSheetHistoryQuarterlyQuoteSummary QuoteSummary { get; set; } = new();
}