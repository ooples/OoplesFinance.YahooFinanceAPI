namespace OoplesFinance.YahooFinanceAPI.Models;

public class AccountsPayable
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class BalanceSheetHistory
{
    [JsonPropertyName("balanceSheetStatements")]
    public List<BalanceSheetStatement> BalanceSheetStatements { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class BalanceSheetStatement
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("endDate")]
    public EndDate EndDate { get; set; } = new();

    [JsonPropertyName("cash")]
    public Cash Cash { get; set; } = new();

    [JsonPropertyName("shortTermInvestments")] 
    public ShortTermInvestments ShortTermInvestments { get; set; } = new();

    [JsonPropertyName("netReceivables")] 
    public NetReceivables NetReceivables { get; set; } = new();

    [JsonPropertyName("inventory")] 
    public Inventory Inventory { get; set; } = new();

    [JsonPropertyName("otherCurrentAssets")] 
    public OtherCurrentAssets OtherCurrentAssets { get; set; } = new();

    [JsonPropertyName("totalCurrentAssets")] 
    public TotalCurrentAssets TotalCurrentAssets { get; set; } = new();

    [JsonPropertyName("longTermInvestments")] 
    public LongTermInvestments LongTermInvestments { get; set; } = new();

    [JsonPropertyName("propertyPlantEquipment")] 
    public PropertyPlantEquipment PropertyPlantEquipment { get; set; } = new();

    [JsonPropertyName("otherAssets")] 
    public OtherAssets OtherAssets { get; set; } = new();

    [JsonPropertyName("totalAssets")] 
    public TotalAssets TotalAssets { get; set; } = new();

    [JsonPropertyName("accountsPayable")] 
    public AccountsPayable AccountsPayable { get; set; } = new();

    [JsonPropertyName("shortLongTermDebt")] 
    public ShortLongTermDebt ShortLongTermDebt { get; set; } = new();

    [JsonPropertyName("otherCurrentLiab")] 
    public OtherCurrentLiab OtherCurrentLiab { get; set; } = new();

    [JsonPropertyName("longTermDebt")] 
    public LongTermDebt LongTermDebt { get; set; } = new();

    [JsonPropertyName("otherLiab")] 
    public OtherLiab OtherLiab { get; set; } = new();

    [JsonPropertyName("totalCurrentLiabilities")] 
    public TotalCurrentLiabilities TotalCurrentLiabilities { get; set; } = new();

    [JsonPropertyName("totalLiab")] 
    public TotalLiab TotalLiab { get; set; } = new();

    [JsonPropertyName("commonStock")] 
    public CommonStock CommonStock { get; set; } = new();

    [JsonPropertyName("retainedEarnings")] 
    public RetainedEarnings RetainedEarnings { get; set; } = new();

    [JsonPropertyName("treasuryStock")] 
    public TreasuryStock TreasuryStock { get; set; } = new();

    [JsonPropertyName("otherStockholderEquity")] 
    public OtherStockholderEquity OtherStockholderEquity { get; set; } = new();

    [JsonPropertyName("totalStockholderEquity")] 
    public TotalStockholderEquity TotalStockholderEquity { get; set; } = new();

    [JsonPropertyName("netTangibleAssets")] 
    public NetTangibleAssets NetTangibleAssets { get; set; } = new();
}

public class Cash
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class CommonStock
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class EndDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class Inventory
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class LongTermDebt
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class LongTermInvestments
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NetReceivables
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NetTangibleAssets
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherAssets
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherCurrentAssets
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherCurrentLiab
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherLiab
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherStockholderEquity
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class PropertyPlantEquipment
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class BalanceSheetHistoryQuoteSummary
{
    [JsonPropertyName("result")]
    public List<BalanceSheetHistoryResult> Results { get; set; } = new();

    [JsonPropertyName("error")] 
    public object Error { get; set; } = new();
}

public class BalanceSheetHistoryResult
{
    [JsonPropertyName("balanceSheetHistory")] 
    public BalanceSheetHistory BalanceSheetHistory { get; set; } = new();
}

public class RetainedEarnings
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class BalanceSheetHistoryData
{
    [JsonPropertyName("quoteSummary")] 
    public BalanceSheetHistoryQuoteSummary QuoteSummary { get; set; } = new();
}

public class ShortLongTermDebt
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class ShortTermInvestments
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalAssets
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalCurrentAssets
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalCurrentLiabilities
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalLiab
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalStockholderEquity
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class TreasuryStock
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}