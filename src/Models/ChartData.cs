namespace OoplesFinance.YahooFinanceAPI.Models;

public class ChartData
{
    [JsonProperty("timestamp")]
    public List<DateTime> DateList { get; set;  } = new();

    [JsonProperty("close")]
    public List<double> CloseList { get; set; } = new();

    [JsonProperty("high")]
    public List<double> HighList { get; set; } = new();

    [JsonProperty("low")]
    public List<double> LowList { get; set; } = new();

    [JsonProperty("open")]
    public List<double> OpenList { get; set; } = new();

    [JsonProperty("volume")]
    public List<double> VolumeList { get; set; } = new();
}
