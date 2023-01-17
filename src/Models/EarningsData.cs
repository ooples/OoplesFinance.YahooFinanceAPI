namespace OoplesFinance.YahooFinanceAPI.Models;

public class Actual
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class CurrentQuarterEstimate
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EarningsInfo
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("earningsChart")]
    public EarningsChart EarningsChart { get; set; } = new();

    [JsonPropertyName("financialsChart")]
    public FinancialsChart FinancialsChart { get; set; } = new();

    [JsonPropertyName("financialCurrency")]
    public string FinancialCurrency { get; set; } = string.Empty;

    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class EarningsChart
{
    [JsonPropertyName("quarterly")]
    public List<Quarterly> Quarterly { get; set; } = new();

    [JsonPropertyName("currentQuarterEstimate")]
    public CurrentQuarterEstimate CurrentQuarterEstimate { get; set; } = new();

    [JsonPropertyName("currentQuarterEstimateDate")]
    public string CurrentQuarterEstimateDate { get; set; } = string.Empty;

    [JsonPropertyName("currentQuarterEstimateYear")]
    public int? CurrentQuarterEstimateYear { get; set; }

    [JsonPropertyName("earningsDate")]
    public List<EarningsDate> EarningsDate { get; set; } = new();
}

public class EarningsEstimateInfo
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FinancialsChart
{
    [JsonPropertyName("yearly")]
    public List<Yearly> Yearly { get; set; } = new();

    [JsonPropertyName("quarterly")]
    public List<Quarterly> Quarterly { get; set; } = new();
}

public class Quarterly
{
    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;

    [JsonPropertyName("actual")]
    public Actual Actual { get; set; } = new();

    [JsonPropertyName("estimate")] 
    public EarningsEstimateInfo Estimate { get; set; } = new();

    [JsonPropertyName("revenue")] 
    public Revenue Revenue { get; set; } = new();

    [JsonPropertyName("earnings")]
    public EarningsInfo Earnings { get; set; } = new();
}

public class EarningsQuoteSummary
{
    [JsonPropertyName("result")]
    public List<EarningsResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class EarningsResult
{
    [JsonPropertyName("earnings")] 
    public EarningsInfo Earnings { get; set; } = new();
}

public class Revenue
{
    [JsonPropertyName("raw")]
    public object Raw { get; set; } = new();

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class EarningsData
{
    [JsonPropertyName("quoteSummary")]
    public EarningsQuoteSummary QuoteSummary { get; set; } = new();
}

public class Yearly
{
    [JsonPropertyName("date")]
    public int? Date { get; set; }

    [JsonPropertyName("revenue")]
    public Revenue Revenue { get; set; } = new();

    [JsonPropertyName("earnings")]
    public EarningsInfo Earnings { get; set; } = new();
}