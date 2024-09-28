namespace OoplesFinance.YahooFinanceAPI.Models;

public class ChartData
{
    [JsonProperty("result")]
    public List<ChartResult> Result { get; set; } = [];

    [JsonProperty("error")]
    public object Error { get; set; } = new();
}

public class TradingPeriod
{
    [JsonProperty("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonProperty("end")]
    public int? End { get; set; }

    [JsonProperty("start")]
    public int? Start { get; set; }

    [JsonProperty("gmtoffset")]
    public int? Gmtoffset { get; set; }
}

public class ChartResult
{
    [JsonProperty("meta")]
    public Meta? Meta { get; set; }

    [JsonProperty("timestamp")]
    public List<long> Timestamp { get; set; } = [];

    [JsonProperty("indicators")]
    public Indicators? Indicators { get; set; }
}

public class ChartRoot
{
    [JsonProperty("chart")]
    public ChartData Chart { get; set; } = new();
}

public class ChartInfo
{
    public List<DateTime> DateList { get; set; } = [];

    public List<double> OpenList { get; set; } = [];

    public List<double> HighList { get; set; } = [];

    public List<double> LowList { get; set; } = [];

    public List<double> CloseList { get; set; } = [];

    public List<double> VolumeList { get; set; } = [];
}