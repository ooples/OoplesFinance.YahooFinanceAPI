namespace OoplesFinance.YahooFinanceAPI.Models;

public class CashflowStatementHistoryQuarterly
{
    [JsonPropertyName("cashflowStatements")] 
    public List<CashflowStatement> CashflowStatements { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class CashflowStatementHistoryQuarterlyQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<CashflowStatementHistoryQuarterlyResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class CashflowStatementHistoryQuarterlyResult
{
    [JsonPropertyName("cashflowStatementHistoryQuarterly")]
    public CashflowStatementHistoryQuarterly CashflowStatementHistoryQuarterly { get; set; } = new();
}

public class CashflowStatementHistoryQuarterlyData
{
    [JsonPropertyName("quoteSummary")]
    public CashflowStatementHistoryQuarterlyQuoteSummary QuoteSummary { get; set; } = new();
}