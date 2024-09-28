namespace OoplesFinance.YahooFinanceAPI.Models;

[Serializable]

public class HistoricalDataRoot
{
    [JsonProperty("chart")]
    public Chart? Chart { get; set; }
}

public class Chart
{
    [JsonProperty("result")]
    public List<Result> Result { get; set; } = [];

    [JsonProperty("error")]
    public object Error { get; set; } = new();
}

public class Result
{
    [JsonProperty("meta")]
    public Meta Meta { get; set; } = new();

    [JsonProperty("timestamp")]
    public List<int?> Timestamp { get; set; } = [];

    [JsonProperty("indicators")]
    public Indicators Indicators { get; set; } = new();
}