namespace OoplesFinance.YahooFinanceAPI.Models;

[Serializable]
public class Adjclose
{
    [JsonProperty("adjclose")]
    public List<double?> AdjClose { get; set; } = [];
}

public class Chart
{
    [JsonProperty("result")]
    public List<HistoricalDataResult> Result { get; set; } = [];

    [JsonProperty("error")]
    public object Error { get; set; } = new();
}

public class HistoricalDataIndicators
{
    [JsonProperty("quote")]
    public List<HistoricalDataQuote> Quote { get; set; } = [];

    [JsonProperty("adjclose")]
    public List<Adjclose> Adjclose { get; set; } = [];
}

public class Post
{
    [JsonProperty("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonProperty("start")]
    public int? Start { get; set; }

    [JsonProperty("end")]
    public int? End { get; set; }

    [JsonProperty("gmtoffset")]
    public int? Gmtoffset { get; set; }
}

public class Pre
{
    [JsonProperty("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonProperty("start")]
    public int? Start { get; set; }

    [JsonProperty("end")]
    public int? End { get; set; }

    [JsonProperty("gmtoffset")]
    public int? Gmtoffset { get; set; }
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

public class Regular
{
    [JsonProperty("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonProperty("start")]
    public int? Start { get; set; }

    [JsonProperty("end")]
    public int? End { get; set; }

    [JsonProperty("gmtoffset")]
    public int? Gmtoffset { get; set; }
}

public class HistoricalDataResult
{
    [JsonProperty("meta")]
    public Meta Meta { get; set; } = new();

    [JsonProperty("timestamp")]
    public List<int?> Timestamp { get; set; } = [];

    [JsonProperty("indicators")]
    public Indicators Indicators { get; set; } = new();
}

public class HistoricalDataRoot
{
    [JsonProperty("chart")]
    public Chart Chart { get; set; } = new();
}