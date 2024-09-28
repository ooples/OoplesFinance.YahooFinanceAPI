namespace OoplesFinance.YahooFinanceAPI.Models;

public class ChartData
{
    [JsonProperty("result")]
    public List<ChartResult> Result { get; set; } = [];

    [JsonProperty("error")]
    public object Error { get; set; } = new();
}

public class CurrentTradingPeriod
{
    [JsonProperty("pre")]
    public TradingPeriod Pre { get; set; } = new();

    [JsonProperty("regular")]
    public TradingPeriod Regular { get; set; } = new();

    [JsonProperty("post")]
    public TradingPeriod Post { get; set; } = new();
}

public class Indicators
{
    [JsonProperty("quote")]
    public List<HistoricalDataQuote> Quote { get; set; } = [];
}

public class Meta
{
    [JsonProperty("currency")]
    public string Currency { get; set; } = string.Empty;

    [JsonProperty("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonProperty("exchangeName")]
    public string ExchangeName { get; set; } = string.Empty;

    [JsonProperty("instrumentType")]
    public string InstrumentType { get; set; } = string.Empty;

    [JsonProperty("firstTradeDate")]
    public int? FirstTradeDate { get; set; }

    [JsonProperty("regularMarketTime")]
    public int? RegularMarketTime { get; set; }

    [JsonProperty("hasPrePostMarketData")]
    public bool? HasPrePostMarketData { get; set; }

    [JsonProperty("gmtoffset")]
    public int? Gmtoffset { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonProperty("exchangeTimezoneName")]
    public string ExchangeTimezoneName { get; set; } = string.Empty;

    [JsonProperty("regularMarketPrice")]
    public double? RegularMarketPrice { get; set; }

    [JsonProperty("chartPreviousClose")]
    public double? ChartPreviousClose { get; set; }

    [JsonProperty("previousClose")]
    public double? PreviousClose { get; set; }

    [JsonProperty("scale")]
    public int? Scale { get; set; }

    [JsonProperty("priceHint")]
    public int? PriceHint { get; set; }

    [JsonProperty("currentTradingPeriod")]
    public CurrentTradingPeriod CurrentTradingPeriod { get; set; } = new();

    [JsonProperty("tradingPeriods")]
    public List<List<TradingPeriod>> TradingPeriods { get; set; } = [];

    [JsonProperty("dataGranularity")]
    public string DataGranularity { get; set; } = string.Empty;

    [JsonProperty("range")]
    public string Range { get; set; } = string.Empty;

    [JsonProperty("validRanges")]
    public List<string> ValidRanges { get; set; } = [];
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

public class Quote
{
    [JsonProperty("open")]
    public List<double?> Open { get; set; } = [];

    [JsonProperty("low")]
    public List<double?> Low { get; set; } = [];

    [JsonProperty("volume")]
    public List<double?> Volume { get; set; } = [];

    [JsonProperty("close")]
    public List<double?> Close { get; set; } = [];

    [JsonProperty("high")]
    public List<double?> High { get; set; } = [];
}

public class ChartResult
{
    [JsonProperty("meta")]
    public Meta Meta { get; set; } = new();

    [JsonProperty("timestamp")]
    public List<long> Timestamp { get; set; } = [];

    [JsonProperty("indicators")]
    public Indicators Indicators { get; set; } = new();
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