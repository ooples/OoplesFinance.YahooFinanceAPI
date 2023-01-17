namespace OoplesFinance.YahooFinanceAPI.Models;

public class AssetProfile
{
    [JsonPropertyName("address1")]
    public string Address1 { get; set; } = string.Empty;

    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;

    [JsonPropertyName("state")] 
    public string State { get; set; } = string.Empty;

    [JsonPropertyName("zip")] 
    public string Zip { get; set; } = string.Empty;

    [JsonPropertyName("country")] 
    public string Country { get; set; } = string.Empty;

    [JsonPropertyName("phone")] 
    public string Phone { get; set; } = string.Empty;

    [JsonPropertyName("website")] 
    public string Website { get; set; } = string.Empty;

    [JsonPropertyName("industry")] 
    public string Industry { get; set; } = string.Empty;

    [JsonPropertyName("sector")] 
    public string Sector { get; set; } = string.Empty;

    [JsonPropertyName("longBusinessSummary")] 
    public string LongBusinessSummary { get; set; } = string.Empty;

    [JsonPropertyName("fullTimeEmployees")]
    public int? FullTimeEmployees { get; set; }

    [JsonPropertyName("companyOfficers")]
    public List<CompanyOfficer> CompanyOfficers { get; set; } = new();

    [JsonPropertyName("auditRisk")]
    public int? AuditRisk { get; set; }

    [JsonPropertyName("boardRisk")]
    public int? BoardRisk { get; set; }

    [JsonPropertyName("compensationRisk")]
    public int? CompensationRisk { get; set; }

    [JsonPropertyName("shareHolderRightsRisk")]
    public int? ShareHolderRightsRisk { get; set; }

    [JsonPropertyName("overallRisk")]
    public int? OverallRisk { get; set; }

    [JsonPropertyName("governanceEpochDate")]
    public int? GovernanceEpochDate { get; set; }

    [JsonPropertyName("compensationAsOfEpochDate")]
    public int? CompensationAsOfEpochDate { get; set; }

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class CompanyOfficer
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("age")]
    public int? Age { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("yearBorn")]
    public int? YearBorn { get; set; }

    [JsonPropertyName("fiscalYear")]
    public int? FiscalYear { get; set; }

    [JsonPropertyName("totalPay")]
    public TotalPay TotalPay { get; set; } = new();

    [JsonPropertyName("exercisedValue")]
    public ExercisedValue ExercisedValue { get; set; } = new();

    [JsonPropertyName("unexercisedValue")]
    public UnexercisedValue UnexercisedValue { get; set; } = new();
}

public class ExercisedValue
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public object Fmt { get; set; } = new();

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class AssetProfileQuoteSummary
{
    [JsonPropertyName("result")]
    public List<AssetProfileResult> Results { get; set; } = new();

    [JsonPropertyName("error")] 
    public object Error { get; set; } = new();
}

public class AssetProfileResult
{
    [JsonPropertyName("assetProfile")] 
    public AssetProfile AssetProfile { get; set; } = new();
}

public class AssetProfileData
{
    [JsonPropertyName("quoteSummary")] 
    public AssetProfileQuoteSummary QuoteSummary { get; set; } = new();
}

public class TotalPay
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class UnexercisedValue
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public object Fmt { get; set; } = new();

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}