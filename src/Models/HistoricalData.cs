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
    public List<long?> Timestamp { get; set; } = [];

    [JsonProperty("indicators")]
    public Indicators Indicators { get; set; } = new();
}

public class HistoricalChartInfo
{
    public DateTime Date { get; set; }

    public double Open { get; set; }

    public double High { get; set; }

    public double Low { get; set; }

    public double Close { get; set; }

    public double AdjustedClose { get; set; }

    public long Volume { get; set; }
}