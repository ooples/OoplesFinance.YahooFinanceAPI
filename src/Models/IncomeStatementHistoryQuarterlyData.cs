namespace OoplesFinance.YahooFinanceAPI.Models;

public class IncomeStatementHistoryItem
{
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

public class IncomeStatementHistoryQuarterly
{
    [JsonPropertyName("incomeStatementHistory")]
    public List<IncomeStatementHistoryItem> IncomeStatementHistory { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class IncomeStatementHistoryQuarterlyQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<IncomeStatementHistoryQuarterlyResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class IncomeStatementHistoryQuarterlyResult
{
    [JsonPropertyName("incomeStatementHistoryQuarterly")]
    public IncomeStatementHistoryQuarterly IncomeStatementHistoryQuarterly { get; set; } = new();
}

public class IncomeStatementHistoryQuarterlyData
{
    [JsonPropertyName("quoteSummary")]
    public IncomeStatementHistoryQuarterlyQuoteSummary QuoteSummary { get; set; } = new();
}