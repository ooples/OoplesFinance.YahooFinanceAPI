namespace OoplesFinance.YahooFinanceAPI.Models;

public class Company
{
    [JsonPropertyName("innovativeness")]
    public double? Innovativeness { get; set; }

    [JsonPropertyName("hiring")]
    public double? Hiring { get; set; }

    [JsonPropertyName("sustainability")]
    public double? Sustainability { get; set; }

    [JsonPropertyName("insiderSentiments")]
    public double? InsiderSentiments { get; set; }

    [JsonPropertyName("earningsReports")]
    public double? EarningsReports { get; set; }

    [JsonPropertyName("dividends")]
    public double? Dividends { get; set; }
}

public class CompanySnapshot
{
    [JsonPropertyName("sectorInfo")]
    public string SectorInfo { get; set; } = string.Empty;

    [JsonPropertyName("company")] 
    public Company Company { get; set; } = new();

    [JsonPropertyName("sector")] 
    public Sector Sector { get; set; } = new();
}

public class Finance
{
    [JsonPropertyName("result")]
    public InsightsResult Result { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class InstrumentInfo
{
    [JsonPropertyName("technicalEvents")]
    public TechnicalEvents TechnicalEvents { get; set; } = new();

    [JsonPropertyName("keyTechnicals")]
    public KeyTechnicals KeyTechnicals { get; set; } = new();

    [JsonPropertyName("valuation")]
    public Valuation Valuation { get; set; } = new();

    [JsonPropertyName("recommendation")] 
    public Recommendation Recommendation { get; set; } = new();
}

public class KeyTechnicals
{
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = string.Empty;

    [JsonPropertyName("support")]
    public double? Support { get; set; }

    [JsonPropertyName("resistance")]
    public double? Resistance { get; set; }

    [JsonPropertyName("stopLoss")]
    public double? StopLoss { get; set; }
}

public class Recommendation
{
    [JsonPropertyName("targetPrice")]
    public double? TargetPrice { get; set; }

    [JsonPropertyName("provider")]
    public string Provider { get; set; } = string.Empty;

    [JsonPropertyName("rating")]
    public string Rating { get; set; } = string.Empty;
}

public class Report
{
    [JsonPropertyName("id")] 
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("provider")] 
    public string Provider { get; set; } = string.Empty;

    [JsonPropertyName("publishedOn")]
    public DateTime? PublishedOn { get; set; } = new();

    [JsonPropertyName("summary")] 
    public string Summary { get; set; } = string.Empty;
}

public class InsightsResult
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("instrumentInfo")]
    public InstrumentInfo InstrumentInfo { get; set; } = new();

    [JsonPropertyName("reports")]
    public List<Report> Reports { get; set; } = new();

    [JsonPropertyName("companySnapshot")] 
    public CompanySnapshot CompanySnapshot { get; set; } = new();
}

public class InsightsData
{
    [JsonPropertyName("finance")] 
    public Finance Finance { get; set; } = new();
}

public class Sector
{
    [JsonPropertyName("innovativeness")]
    public double? Innovativeness { get; set; }

    [JsonPropertyName("hiring")]
    public double? Hiring { get; set; }

    [JsonPropertyName("sustainability")]
    public double? Sustainability { get; set; }

    [JsonPropertyName("insiderSentiments")]
    public double? InsiderSentiments { get; set; }

    [JsonPropertyName("earningsReports")]
    public double? EarningsReports { get; set; }

    [JsonPropertyName("dividends")]
    public double? Dividends { get; set; }
}

public class TechnicalEvents
{
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = string.Empty;

    [JsonPropertyName("shortTerm")]
    public string ShortTerm { get; set; } = string.Empty;

    [JsonPropertyName("midTerm")] 
    public string MidTerm { get; set; } = string.Empty;

    [JsonPropertyName("longTerm")] 
    public string LongTerm { get; set; } = string.Empty;
}

public class Valuation
{
    [JsonPropertyName("color")]
    public double? Color { get; set; }

    [JsonPropertyName("description")] 
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("discount")] 
    public string Discount { get; set; } = string.Empty;

    [JsonPropertyName("relativeValue")] 
    public string RelativeValue { get; set; } = string.Empty;

    [JsonPropertyName("provider")] 
    public string Provider { get; set; } = string.Empty;
}