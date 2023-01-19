namespace OoplesFinance.YahooFinanceAPI.Models;

public class Chart
{
    [JsonPropertyName("result")] 
    public List<ChartResult> Results { get; set; } = new();

    [JsonPropertyName("error")] 
    public object Error { get; set; } = new();
}

public class CurrentTradingPeriod
{
    [JsonPropertyName("pre")]
    public Pre Pre { get; set; } = new();

    [JsonPropertyName("regular")] 
    public Regular Regular { get; set; } = new();

    [JsonPropertyName("post")] 
    public Post Post { get; set; } = new();
}

public class Indicators
{
    [JsonPropertyName("quote")]
    public List<ChartQuote> Quote { get; set; } = new();
}

public class Meta
{
    [JsonPropertyName("currency")]
    public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("exchangeName")]
    public string ExchangeName { get; set; } = string.Empty;

    [JsonPropertyName("instrumentType")] 
    public string InstrumentType { get; set; } = string.Empty;

    [JsonPropertyName("firstTradeDate")]
    public int? FirstTradeDate { get; set; }

    [JsonPropertyName("regularMarketTime")]
    public int? RegularMarketTime { get; set; }

    [JsonPropertyName("gmtoffset")]
    public int? Gmtoffset { get; set; }

    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonPropertyName("exchangeTimezoneName")]
    public string ExchangeTimezoneName { get; set; } = string.Empty;

    [JsonPropertyName("regularMarketPrice")]
    public double? RegularMarketPrice { get; set; }

    [JsonPropertyName("chartPreviousClose")]
    public double? ChartPreviousClose { get; set; }

    [JsonPropertyName("previousClose")]
    public double? PreviousClose { get; set; }

    [JsonPropertyName("scale")]
    public int? Scale { get; set; }

    [JsonPropertyName("priceHint")]
    public int? PriceHint { get; set; }

    [JsonPropertyName("currentTradingPeriod")]
    public CurrentTradingPeriod CurrentTradingPeriod { get; set; } = new();

    [JsonPropertyName("tradingPeriods")]
    public List<List<TradingPeriod>> TradingPeriods { get; set; } = new();

    [JsonPropertyName("dataGranularity")]
    public string DataGranularity { get; set; } = string.Empty;

    [JsonPropertyName("range")]
    public string Range { get; set; } = string.Empty;

    [JsonPropertyName("validRanges")] 
    public List<string> ValidRanges { get; set; } = new();
}

public class TradingPeriod
{
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonPropertyName("start")]
    public int? Start { get; set; }

    [JsonPropertyName("end")]
    public int? End { get; set; }

    [JsonPropertyName("gmtoffset")]
    public int? Gmtoffset { get; set; }
}

public class Post
{
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonPropertyName("start")]
    public int? Start { get; set; }

    [JsonPropertyName("end")]
    public int? End { get; set; }

    [JsonPropertyName("gmtoffset")]
    public int? Gmtoffset { get; set; }
}

public class Pre
{
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonPropertyName("start")]
    public int? Start { get; set; }

    [JsonPropertyName("end")]
    public int? End { get; set; }

    [JsonPropertyName("gmtoffset")]
    public int? Gmtoffset { get; set; }
}

public class ChartQuote
{
    [JsonPropertyName("open")] 
    public List<double?> Open { get; set; } = new();

    [JsonPropertyName("close")] 
    public List<double?> Close { get; set; } = new();

    [JsonPropertyName("high")] 
    public List<double?> High { get; set; } = new();

    [JsonPropertyName("low")] 
    public List<double?> Low { get; set; } = new();

    [JsonPropertyName("volume")]
    public List<int?> Volume { get; set; } = new();
}

public class Regular
{
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonPropertyName("start")]
    public int? Start { get; set; }

    [JsonPropertyName("end")]
    public int? End { get; set; }

    [JsonPropertyName("gmtoffset")]
    public int? Gmtoffset { get; set; }
}

public class ChartResult
{
    [JsonPropertyName("meta")] 
    public Meta Meta { get; set; } = new();

    [JsonPropertyName("timestamp")]
    public List<int?> Timestamp { get; set; } = new();

    [JsonPropertyName("indicators")]
    public Indicators Indicators { get; set; } = new();
}

public class ChartData
{
    [JsonPropertyName("chart")]
    public Chart Chart { get; set; } = new();
}