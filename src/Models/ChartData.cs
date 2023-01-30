namespace OoplesFinance.YahooFinanceAPI.Models;

public class ChartData
{
    [JsonPropertyName("timestamp")]
    public List<DateTime> DateList { get; set;  } = new();

    [JsonPropertyName("close")]
    public List<double> CloseList { get; set; } = new();

    [JsonPropertyName("high")]
    public List<double> HighList { get; set; } = new();

    [JsonPropertyName("low")]
    public List<double> LowList { get; set; } = new();

    [JsonPropertyName("open")]
    public List<double> OpenList { get; set; } = new();

    [JsonPropertyName("volume")]
    public List<double> VolumeList { get; set; } = new();
}
