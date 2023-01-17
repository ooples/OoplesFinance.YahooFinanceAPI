namespace OoplesFinance.YahooFinanceAPI.Models;

public class CapitalExpenditures
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class CashflowStatement
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("endDate")] 
    public EndDate EndDate { get; set; } = new();

    [JsonPropertyName("netIncome")] 
    public NetIncome NetIncome { get; set; } = new();

    [JsonPropertyName("depreciation")] 
    public Depreciation Depreciation { get; set; } = new();

    [JsonPropertyName("changeToNetincome")] 
    public ChangeToNetincome ChangeToNetincome { get; set; } = new();

    [JsonPropertyName("changeToAccountReceivables")] 
    public ChangeToAccountReceivables ChangeToAccountReceivables { get; set; } = new();

    [JsonPropertyName("changeToLiabilities")] 
    public ChangeToLiabilities ChangeToLiabilities { get; set; } = new();

    [JsonPropertyName("changeToInventory")] 
    public ChangeToInventory ChangeToInventory { get; set; } = new();

    [JsonPropertyName("changeToOperatingActivities")] 
    public ChangeToOperatingActivities ChangeToOperatingActivities { get; set; } = new();

    [JsonPropertyName("totalCashFromOperatingActivities")] 
    public TotalCashFromOperatingActivities TotalCashFromOperatingActivities { get; set; } = new();

    [JsonPropertyName("capitalExpenditures")] 
    public CapitalExpenditures CapitalExpenditures { get; set; } = new();

    [JsonPropertyName("investments")] 
    public Investments Investments { get; set; } = new();

    [JsonPropertyName("otherCashflowsFromInvestingActivities")] 
    public OtherCashflowsFromInvestingActivities OtherCashflowsFromInvestingActivities { get; set; } = new();

    [JsonPropertyName("totalCashflowsFromInvestingActivities")] 
    public TotalCashflowsFromInvestingActivities TotalCashflowsFromInvestingActivities { get; set; } = new();

    [JsonPropertyName("dividendsPaid")] 
    public DividendsPaid DividendsPaid { get; set; } = new();

    [JsonPropertyName("netBorrowings")] 
    public NetBorrowings NetBorrowings { get; set; } = new();

    [JsonPropertyName("otherCashflowsFromFinancingActivities")] 
    public OtherCashflowsFromFinancingActivities OtherCashflowsFromFinancingActivities { get; set; } = new();

    [JsonPropertyName("totalCashFromFinancingActivities")] 
    public TotalCashFromFinancingActivities TotalCashFromFinancingActivities { get; set; } = new();

    [JsonPropertyName("changeInCash")] 
    public ChangeInCash ChangeInCash { get; set; } = new();

    [JsonPropertyName("repurchaseOfStock")] 
    public RepurchaseOfStock RepurchaseOfStock { get; set; } = new();

    [JsonPropertyName("issuanceOfStock")]
    public IssuanceOfStock IssuanceOfStock { get; set; } = new();
}

public class CashflowStatementHistory
{
    [JsonPropertyName("cashflowStatements")]
    public List<CashflowStatement> CashflowStatements { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class ChangeInCash
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class ChangeToAccountReceivables
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class ChangeToInventory
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class ChangeToLiabilities
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class ChangeToNetincome
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class ChangeToOperatingActivities
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class Depreciation
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class DividendsPaid
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class Investments
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class IssuanceOfStock
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NetBorrowings
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class NetIncome
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherCashflowsFromFinancingActivities
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherCashflowsFromInvestingActivities
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class CashflowStatementHistoryQuoteSummary
{
    [JsonPropertyName("result")]
    public List<CashflowStatementHistoryResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class RepurchaseOfStock
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class CashflowStatementHistoryResult
{
    [JsonPropertyName("cashflowStatementHistory")]
    public CashflowStatementHistory CashflowStatementHistory { get; set; } = new();
}

public class CashflowStatementHistoryData
{
    [JsonPropertyName("quoteSummary")]
    public CashflowStatementHistoryQuoteSummary QuoteSummary { get; set; } = new();
}

public class TotalCashflowsFromInvestingActivities
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalCashFromFinancingActivities
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalCashFromOperatingActivities
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}