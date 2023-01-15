namespace OoplesFinance.YahooFinanceAPI.Models;

public class Holder
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("relation")]
    public string Relation { get; set; } = string.Empty;

    [JsonPropertyName("url")] 
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("transactionDescription")] 
    public string TransactionDescription { get; set; } = string.Empty;

    [JsonPropertyName("latestTransDate")]
    public LatestTransDate LatestTransDate { get; set; } = new();

    [JsonPropertyName("positionDirect")]
    public PositionDirect PositionDirect { get; set; } = new();

    [JsonPropertyName("positionDirectDate")] 
    public PositionDirectDate PositionDirectDate { get; set; } = new();

    [JsonPropertyName("positionIndirect")] 
    public PositionIndirect PositionIndirect { get; set; } = new();

    [JsonPropertyName("positionIndirectDate")] 
    public PositionIndirectDate PositionIndirectDate { get; set; } = new();
}

public class InsiderHolders
{
    [JsonPropertyName("holders")]
    public List<Holder> Holders { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class LatestTransDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PositionDirect
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class PositionDirectDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class PositionIndirect
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class PositionIndirectDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class InsiderHolderQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<InsiderHolderResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class InsiderHolderResult
{
    [JsonPropertyName("insiderHolders")]
    public InsiderHolders InsiderHolders { get; set; } = new();
}

public class InsiderHolderData
{
    [JsonPropertyName("quoteSummary")]
    public InsiderHolderQuoteSummary QuoteSummary { get; set; } = new();
}