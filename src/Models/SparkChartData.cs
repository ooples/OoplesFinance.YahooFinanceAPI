namespace OoplesFinance.YahooFinanceAPI.Models;

public class SparkInfo
{
    [JsonPropertyName("timestamp")] 
    public List<int?> Timestamp { get; set; } = new();

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("previousClose")] 
    public object PreviousClose { get; set; } = new();

    [JsonPropertyName("chartPreviousClose")]
    public double? ChartPreviousClose { get; set; }

    [JsonPropertyName("dataGranularity")]
    public int? DataGranularity { get; set; }

    [JsonPropertyName("end")] 
    public object End { get; set; } = new();

    [JsonPropertyName("start")]
    public object Start { get; set; } = new();

    [JsonPropertyName("close")]
    public List<double?> Close { get; set; } = new();
}

public class SparkChartData
{
    public SparkInfo Result { get; set; } = new();
}