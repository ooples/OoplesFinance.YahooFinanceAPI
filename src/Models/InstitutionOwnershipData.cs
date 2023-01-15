namespace OoplesFinance.YahooFinanceAPI.Models;

public class InstitutionOwnership
{
    [JsonPropertyName("ownershipList")]
    public List<OwnershipList> OwnershipList { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class OwnershipList
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("reportDate")]
    public ReportDate ReportDate { get; set; } = new();

    [JsonPropertyName("organization")]
    public string Organization { get; set; } = string.Empty;

    [JsonPropertyName("pctHeld")]
    public PctHeld PctHeld { get; set; } = new();

    [JsonPropertyName("position")] 
    public Position Position { get; set; } = new();

    [JsonPropertyName("value")]
    public Value Value { get; set; } = new();
}

public class PctHeld
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class Position
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class InstitutionOwnershipQuoteSummary
{
    [JsonPropertyName("result")]
    public List<InstitutionOwnershipResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class ReportDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class InstitutionOwnershipResult
{
    [JsonPropertyName("institutionOwnership")]
    public InstitutionOwnership InstitutionOwnership { get; set; } = new();
}

public class InstitutionOwnershipData
{
    [JsonPropertyName("quoteSummary")]
    public InstitutionOwnershipQuoteSummary QuoteSummary { get; set; } = new();
}
