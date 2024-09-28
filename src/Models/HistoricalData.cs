namespace OoplesFinance.YahooFinanceAPI.Models;

[Serializable]
public class HistoricalDataIndicators
{
    [JsonProperty("quote")]
    public List<HistoricalDataQuote> Quote { get; set; } = [];

    [JsonProperty("adjclose")]
    public List<AdjClose> Adjclose { get; set; } = [];
}

public class HistoricalDataQuote
{
    [JsonProperty("high")]
    public List<double?> High { get; set; } = [];

    [JsonProperty("low")]
    public List<double?> Low { get; set; } = [];

    [JsonProperty("close")]
    public List<double?> Close { get; set; } = [];

    [JsonProperty("open")]
    public List<double?> Open { get; set; } = [];

    [JsonProperty("volume")]
    public List<int?> Volume { get; set; } = [];
}

public class HistoricalDataResult
{
    [JsonProperty("meta")]
    public Meta? Meta { get; set; }

    [JsonProperty("timestamp")]
    public List<int?> Timestamp { get; set; } = [];

    [JsonProperty("indicators")]
    public Indicators? Indicators { get; set; }
}

public class HistoricalDataRoot
{
    [JsonProperty("chart")]
    public Chart? Chart { get; set; }
}