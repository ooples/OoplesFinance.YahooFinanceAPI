namespace OoplesFinance.YahooFinanceAPI.Models;

public class _10y
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class _3y
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class _5y
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class AnnualReportExpenseRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class DeferredSalesLoad
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FeesExpensesInvestment
{
    [JsonPropertyName("annualReportExpenseRatio")]
    public AnnualReportExpenseRatio AnnualReportExpenseRatio { get; set; } = new();

    [JsonPropertyName("frontEndSalesLoad")]
    public FrontEndSalesLoad FrontEndSalesLoad { get; set; } = new();

    [JsonPropertyName("deferredSalesLoad")] 
    public DeferredSalesLoad DeferredSalesLoad { get; set; } = new();

    [JsonPropertyName("twelveBOne")] 
    public TwelveBOne TwelveBOne { get; set; } = new();

    [JsonPropertyName("netExpRatio")] 
    public NetExpRatio NetExpRatio { get; set; } = new();

    [JsonPropertyName("grossExpRatio")] 
    public GrossExpRatio GrossExpRatio { get; set; } = new();

    [JsonPropertyName("annualHoldingsTurnover")] 
    public AnnualHoldingsTurnover AnnualHoldingsTurnover { get; set; } = new();

    [JsonPropertyName("totalNetAssets")] 
    public TotalNetAssets TotalNetAssets { get; set; } = new();

    [JsonPropertyName("projectionValues")] 
    public ProjectionValues ProjectionValues { get; set; } = new();
}

public class FeesExpensesInvestmentCat
{
    [JsonPropertyName("annualReportExpenseRatio")] 
    public AnnualReportExpenseRatio AnnualReportExpenseRatio { get; set; } = new();

    [JsonPropertyName("frontEndSalesLoad")] 
    public FrontEndSalesLoad FrontEndSalesLoad { get; set; } = new();

    [JsonPropertyName("deferredSalesLoad")] 
    public DeferredSalesLoad DeferredSalesLoad { get; set; } = new();

    [JsonPropertyName("twelveBOne")] 
    public TwelveBOne TwelveBOne { get; set; } = new();

    [JsonPropertyName("annualHoldingsTurnover")] 
    public AnnualHoldingsTurnover AnnualHoldingsTurnover { get; set; } = new();

    [JsonPropertyName("totalNetAssets")] 
    public TotalNetAssets TotalNetAssets { get; set; } = new();

    [JsonPropertyName("projectionValuesCat")] 
    public ProjectionValuesCat ProjectionValuesCat { get; set; } = new();
}

public class FrontEndSalesLoad
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FundProfile
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("styleBoxUrl")]
    public string StyleBoxUrl { get; set; } = string.Empty;

    [JsonPropertyName("family")]
    public string Family { get; set; } = string.Empty;

    [JsonPropertyName("categoryName")] 
    public string CategoryName { get; set; } = string.Empty;

    [JsonPropertyName("legalType")]
    public object LegalType { get; set; } = new();

    [JsonPropertyName("managementInfo")]
    public ManagementInfo ManagementInfo { get; set; } = new();

    [JsonPropertyName("feesExpensesInvestment")] 
    public FeesExpensesInvestment FeesExpensesInvestment { get; set; } = new();

    [JsonPropertyName("feesExpensesInvestmentCat")] 
    public FeesExpensesInvestmentCat FeesExpensesInvestmentCat { get; set; } = new();

    [JsonPropertyName("initInvestment")] 
    public InitInvestment InitInvestment { get; set; } = new();

    [JsonPropertyName("initIraInvestment")] 
    public InitIraInvestment InitIraInvestment { get; set; } = new();

    [JsonPropertyName("initAipInvestment")] 
    public InitAipInvestment InitAipInvestment { get; set; } = new();

    [JsonPropertyName("subseqInvestment")] 
    public SubseqInvestment SubseqInvestment { get; set; } = new();

    [JsonPropertyName("subseqIraInvestment")] 
    public SubseqIraInvestment SubseqIraInvestment { get; set; } = new();

    [JsonPropertyName("subseqAipInvestment")] 
    public SubseqAipInvestment SubseqAipInvestment { get; set; } = new();

    [JsonPropertyName("brokerages")]
    public List<string> Brokerages { get; set; } = new();
}

public class GrossExpRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class InitAipInvestment
{
}

public class InitInvestment
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class InitIraInvestment
{
}

public class ManagementInfo
{
    [JsonPropertyName("managerName")]
    public string ManagerName { get; set; } = string.Empty;

    [JsonPropertyName("managerBio")]
    public string ManagerBio { get; set; } = string.Empty;

    [JsonPropertyName("startdate")]
    public Startdate Startdate { get; set; } = new();
}

public class NetExpRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ProjectionValues
{
    [JsonPropertyName("5y")]
    public _5y _5y { get; set; } = new();

    [JsonPropertyName("3y")]
    public _3y _3y { get; set; } = new();

    [JsonPropertyName("10y")]
    public _10y _10y { get; set; } = new();
}

public class ProjectionValuesCat
{
    [JsonPropertyName("5y")]
    public _5y _5y { get; set; } = new();

    [JsonPropertyName("3y")] 
    public _3y _3y { get; set; } = new();

    [JsonPropertyName("10y")] 
    public _10y _10y { get; set; } = new();
}

public class FundProfileQuoteSummary
{
    [JsonPropertyName("result")]
    public List<FundProfileResult> Results { get; set; } = new();

    [JsonPropertyName("error")] 
    public object Error { get; set; } = new();
}

public class FundProfileResult
{
    [JsonPropertyName("fundProfile")] 
    public FundProfile FundProfile { get; set; } = new();
}

public class FundProfileData
{
    [JsonPropertyName("quoteSummary")] 
    public FundProfileQuoteSummary QuoteSummary { get; set; } = new();
}

public class Startdate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class SubseqAipInvestment
{
}

public class SubseqInvestment
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class SubseqIraInvestment
{
}

public class TotalNetAssets
{
}

public class TwelveBOne
{
}