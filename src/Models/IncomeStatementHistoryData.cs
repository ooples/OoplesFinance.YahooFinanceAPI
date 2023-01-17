namespace OoplesFinance.YahooFinanceAPI.Models;

public class CostOfRevenue
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class DiscontinuedOperations
{
}

public class Ebit
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class EffectOfAccountingCharges
{
}

public class ExtraordinaryItems
{
}

public class GrossProfit
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class IncomeBeforeTax
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class IncomeStatementHistory
{
    [JsonPropertyName("incomeStatementHistory")]
    public List<IncomeStatementHistory> IncomeStatementHistoryInfo { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("endDate")]
    public EndDate EndDate { get; set; } = new();

    [JsonPropertyName("totalRevenue")] 
    public TotalRevenue TotalRevenue { get; set; } = new();

    [JsonPropertyName("costOfRevenue")] 
    public CostOfRevenue CostOfRevenue { get; set; } = new();

    [JsonPropertyName("grossProfit")] 
    public GrossProfit GrossProfit { get; set; } = new();

    [JsonPropertyName("researchDevelopment")] 
    public ResearchDevelopment ResearchDevelopment { get; set; } = new();

    [JsonPropertyName("sellingGeneralAdministrative")] 
    public SellingGeneralAdministrative SellingGeneralAdministrative { get; set; } = new();

    [JsonPropertyName("nonRecurring")] 
    public NonRecurring NonRecurring { get; set; } = new();

    [JsonPropertyName("otherOperatingExpenses")] 
    public OtherOperatingExpenses OtherOperatingExpenses { get; set; } = new();

    [JsonPropertyName("totalOperatingExpenses")] 
    public TotalOperatingExpenses TotalOperatingExpenses { get; set; } = new();

    [JsonPropertyName("operatingIncome")] 
    public OperatingIncome OperatingIncome { get; set; } = new();

    [JsonPropertyName("totalOtherIncomeExpenseNet")] 
    public TotalOtherIncomeExpenseNet TotalOtherIncomeExpenseNet { get; set; } = new();

    [JsonPropertyName("ebit")] 
    public Ebit Ebit { get; set; } = new();

    [JsonPropertyName("interestExpense")] 
    public InterestExpense InterestExpense { get; set; } = new();

    [JsonPropertyName("incomeBeforeTax")] 
    public IncomeBeforeTax IncomeBeforeTax { get; set; } = new();

    [JsonPropertyName("incomeTaxExpense")] 
    public IncomeTaxExpense IncomeTaxExpense { get; set; } = new();

    [JsonPropertyName("minorityInterest")] 
    public MinorityInterest MinorityInterest { get; set; } = new();

    [JsonPropertyName("netIncomeFromContinuingOps")] 
    public NetIncomeFromContinuingOps NetIncomeFromContinuingOps { get; set; } = new();

    [JsonPropertyName("discontinuedOperations")]
    public DiscontinuedOperations DiscontinuedOperations { get; set; } = new();

    [JsonPropertyName("extraordinaryItems")] 
    public ExtraordinaryItems ExtraordinaryItems { get; set; } = new();

    [JsonPropertyName("effectOfAccountingCharges")] 
    public EffectOfAccountingCharges EffectOfAccountingCharges { get; set; } = new();

    [JsonPropertyName("otherItems")]
    public OtherItems OtherItems { get; set; } = new();

    [JsonPropertyName("netIncome")] 
    public NetIncome NetIncome { get; set; } = new();

    [JsonPropertyName("netIncomeApplicableToCommonShares")] 
    public NetIncomeApplicableToCommonShares NetIncomeApplicableToCommonShares { get; set; } = new();
}

public class IncomeTaxExpense
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class InterestExpense
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class MinorityInterest
{
}

public class NetIncomeApplicableToCommonShares
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NetIncomeFromContinuingOps
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NonRecurring
{
}

public class OperatingIncome
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class OtherItems
{
}

public class OtherOperatingExpenses
{
}

public class IncomeStatementHistoryQuoteSummary
{
    [JsonPropertyName("result")]
    public List<IncomeStatementHistoryResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class ResearchDevelopment
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class IncomeStatementHistoryResult
{
    [JsonPropertyName("incomeStatementHistory")]
    public IncomeStatementHistory IncomeStatementHistory { get; set; } = new();
}

public class IncomeStatementHistoryData
{
    [JsonPropertyName("quoteSummary")]
    public IncomeStatementHistoryQuoteSummary QuoteSummary { get; set; } = new();
}

public class SellingGeneralAdministrative
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalOperatingExpenses
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalOtherIncomeExpenseNet
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}