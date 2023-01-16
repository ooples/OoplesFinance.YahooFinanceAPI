namespace OoplesFinance.YahooFinanceAPI.Models;

public class Filing
{
    [JsonPropertyName("date")] 
    public DateTime Date { get; set; } = new();

    [JsonPropertyName("epochDate")]
    public int? EpochDate { get; set; }

    [JsonPropertyName("type")] 
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("edgarUrl")]
    public string EdgarUrl { get; set; } = string.Empty;

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class SecFilingsQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<SecFilingsResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class SecFilingsResult
{
    [JsonPropertyName("secFilings")] 
    public SecFilings SecFilings { get; set; } = new();
}

public class SecFilingsData
{
    [JsonPropertyName("quoteSummary")]
    public SecFilingsQuoteSummary QuoteSummary { get; set; } = new();
}

public class SecFilings
{
    [JsonPropertyName("filings")]
    public List<Filing> Filings { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}