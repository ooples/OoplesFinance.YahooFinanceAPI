namespace OoplesFinance.YahooFinanceAPI.Models;

public class CurrentPrice
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class CurrentRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class DebtToEquity
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EarningsGrowth
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class Ebitda
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class EbitdaMargins
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class FinancialData
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("currentPrice")]
    public CurrentPrice CurrentPrice { get; set; } = new();

    [JsonPropertyName("targetHighPrice")]
    public TargetHighPrice TargetHighPrice { get; set; } = new();

    [JsonPropertyName("targetLowPrice")] 
    public TargetLowPrice TargetLowPrice { get; set; } = new();

    [JsonPropertyName("targetMeanPrice")] 
    public TargetMeanPrice TargetMeanPrice { get; set; } = new();

    [JsonPropertyName("targetMedianPrice")] 
    public TargetMedianPrice TargetMedianPrice { get; set; } = new();

    [JsonPropertyName("recommendationMean")] 
    public RecommendationMean RecommendationMean { get; set; } = new();

    [JsonPropertyName("recommendationKey")]
    public string RecommendationKey { get; set; } = string.Empty;

    [JsonPropertyName("numberOfAnalystOpinions")] 
    public NumberOfAnalystOpinions NumberOfAnalystOpinions { get; set; } = new();

    [JsonPropertyName("totalCash")] 
    public TotalCash TotalCash { get; set; } = new();

    [JsonPropertyName("totalCashPerShare")] 
    public TotalCashPerShare TotalCashPerShare { get; set; } = new();

    [JsonPropertyName("ebitda")] 
    public Ebitda Ebitda { get; set; } = new();

    [JsonPropertyName("totalDebt")] 
    public TotalDebt TotalDebt { get; set; } = new();

    [JsonPropertyName("quickRatio")] 
    public QuickRatio QuickRatio { get; set; } = new();

    [JsonPropertyName("currentRatio")] 
    public CurrentRatio CurrentRatio { get; set; } = new();

    [JsonPropertyName("totalRevenue")]
    public TotalRevenue TotalRevenue { get; set; } = new();

    [JsonPropertyName("debtToEquity")] 
    public DebtToEquity DebtToEquity { get; set; } = new();

    [JsonPropertyName("revenuePerShare")] 
    public RevenuePerShare RevenuePerShare { get; set; } = new();

    [JsonPropertyName("returnOnAssets")] 
    public ReturnOnAssets ReturnOnAssets { get; set; } = new();

    [JsonPropertyName("returnOnEquity")] 
    public ReturnOnEquity ReturnOnEquity { get; set; } = new();

    [JsonPropertyName("grossProfits")] 
    public GrossProfits GrossProfits { get; set; } = new();

    [JsonPropertyName("freeCashflow")] 
    public FreeCashflow FreeCashflow { get; set; } = new();

    [JsonPropertyName("operatingCashflow")] 
    public OperatingCashflow OperatingCashflow { get; set; } = new();

    [JsonPropertyName("earningsGrowth")] 
    public EarningsGrowth EarningsGrowth { get; set; } = new();

    [JsonPropertyName("revenueGrowth")] 
    public RevenueGrowth RevenueGrowth { get; set; } = new();

    [JsonPropertyName("grossMargins")] 
    public GrossMargins GrossMargins { get; set; } = new();

    [JsonPropertyName("ebitdaMargins")] 
    public EbitdaMargins EbitdaMargins { get; set; } = new();

    [JsonPropertyName("operatingMargins")] 
    public OperatingMargins OperatingMargins { get; set; } = new();

    [JsonPropertyName("profitMargins")] 
    public ProfitMargins ProfitMargins { get; set; } = new();

    [JsonPropertyName("financialCurrency")]
    public string FinancialCurrency { get; set; } = string.Empty;
}

public class FreeCashflow
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class GrossMargins
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class GrossProfits
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NumberOfAnalystOpinions
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OperatingCashflow
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class OperatingMargins
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class QuickRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FinancialQuoteSummary
{
    [JsonPropertyName("result")]
    public List<FinancialDataResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class RecommendationMean
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FinancialDataResult
{
    [JsonPropertyName("financialData")]
    public FinancialData FinancialData { get; set; } = new();
}

public class ReturnOnAssets
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ReturnOnEquity
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RevenueGrowth
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RevenuePerShare
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FinancialDataRoot
{
    [JsonPropertyName("quoteSummary")]
    public FinancialQuoteSummary QuoteSummary { get; set; } = new();
}

public class TargetHighPrice
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TargetLowPrice
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TargetMeanPrice
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TargetMedianPrice
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TotalCash
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalCashPerShare
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class TotalDebt
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class TotalRevenue
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}