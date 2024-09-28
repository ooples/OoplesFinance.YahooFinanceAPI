namespace OoplesFinance.YahooFinanceAPI.Models;

[Serializable]
public record DividendData(
    [property: JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)] double? Amount,
    [property: JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)] int? Date
);

public record AdjClose(
    [property: JsonProperty("adjclose", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<double?> Adjclose
);

public record Chart(
    [property: JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Result> Result,
    [property: JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)] object Error
);

public record CurrentTradingPeriod(
    [property: JsonProperty("pre", NullValueHandling = NullValueHandling.Ignore)] Pre Pre,
    [property: JsonProperty("regular", NullValueHandling = NullValueHandling.Ignore)] Regular Regular,
    [property: JsonProperty("post", NullValueHandling = NullValueHandling.Ignore)] Post Post
);

public record Dividends(
    [property: JsonProperty("dividends", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<DividendData> DividendsList
);

public record Events(
    [property: JsonProperty("dividends", NullValueHandling = NullValueHandling.Ignore)] Dividends Dividends
);

public record Indicators(
    [property: JsonProperty("quote", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<Quote> Quote,
    [property: JsonProperty("adjclose", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<AdjClose> Adjclose
);

public record Meta(
    [property: JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)] string Currency,
    [property: JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)] string Symbol,
    [property: JsonProperty("exchangeName", NullValueHandling = NullValueHandling.Ignore)] string ExchangeName,
    [property: JsonProperty("fullExchangeName", NullValueHandling = NullValueHandling.Ignore)] string FullExchangeName,
    [property: JsonProperty("instrumentType", NullValueHandling = NullValueHandling.Ignore)] string InstrumentType,
    [property: JsonProperty("firstTradeDate", NullValueHandling = NullValueHandling.Ignore)] int? FirstTradeDate,
    [property: JsonProperty("regularMarketTime", NullValueHandling = NullValueHandling.Ignore)] int? RegularMarketTime,
    [property: JsonProperty("hasPrePostMarketData", NullValueHandling = NullValueHandling.Ignore)] bool? HasPrePostMarketData,
    [property: JsonProperty("gmtoffset", NullValueHandling = NullValueHandling.Ignore)] int? Gmtoffset,
    [property: JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)] string Timezone,
    [property: JsonProperty("exchangeTimezoneName", NullValueHandling = NullValueHandling.Ignore)] string ExchangeTimezoneName,
    [property: JsonProperty("regularMarketPrice", NullValueHandling = NullValueHandling.Ignore)] double? RegularMarketPrice,
    [property: JsonProperty("fiftyTwoWeekHigh", NullValueHandling = NullValueHandling.Ignore)] double? FiftyTwoWeekHigh,
    [property: JsonProperty("fiftyTwoWeekLow", NullValueHandling = NullValueHandling.Ignore)] double? FiftyTwoWeekLow,
    [property: JsonProperty("regularMarketDayHigh", NullValueHandling = NullValueHandling.Ignore)] double? RegularMarketDayHigh,
    [property: JsonProperty("regularMarketDayLow", NullValueHandling = NullValueHandling.Ignore)] double? RegularMarketDayLow,
    [property: JsonProperty("regularMarketVolume", NullValueHandling = NullValueHandling.Ignore)] int? RegularMarketVolume,
    [property: JsonProperty("longName", NullValueHandling = NullValueHandling.Ignore)] string LongName,
    [property: JsonProperty("shortName", NullValueHandling = NullValueHandling.Ignore)] string ShortName,
    [property: JsonProperty("chartPreviousClose", NullValueHandling = NullValueHandling.Ignore)] double? ChartPreviousClose,
    [property: JsonProperty("priceHint", NullValueHandling = NullValueHandling.Ignore)] int? PriceHint,
    [property: JsonProperty("currentTradingPeriod", NullValueHandling = NullValueHandling.Ignore)] CurrentTradingPeriod CurrentTradingPeriod,
    [property: JsonProperty("dataGranularity", NullValueHandling = NullValueHandling.Ignore)] string DataGranularity,
    [property: JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)] string Range,
    [property: JsonProperty("validRanges", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<string> ValidRanges
);

public record Post(
    [property: JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)] string Timezone,
    [property: JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)] int? Start,
    [property: JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)] int? End,
    [property: JsonProperty("gmtoffset", NullValueHandling = NullValueHandling.Ignore)] int? Gmtoffset
);

public record Pre(
    [property: JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)] string Timezone,
    [property: JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)] int? Start,
    [property: JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)] int? End,
    [property: JsonProperty("gmtoffset", NullValueHandling = NullValueHandling.Ignore)] int? Gmtoffset
);

public record Quote(
    [property: JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<double?> Close,
    [property: JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<double?> High,
    [property: JsonProperty("low", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<double?> Low,
    [property: JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int?> Volume,
    [property: JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<double?> Open
);

public record Regular(
    [property: JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)] string Timezone,
    [property: JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)] int? Start,
    [property: JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)] int? End,
    [property: JsonProperty("gmtoffset", NullValueHandling = NullValueHandling.Ignore)] int? Gmtoffset
);

public record Result(
    [property: JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)] Meta Meta,
    [property: JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int?> Timestamp,
    [property: JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)] Events Events,
    [property: JsonProperty("indicators", NullValueHandling = NullValueHandling.Ignore)] Indicators Indicators
);

public record Root(
    [property: JsonProperty("chart", NullValueHandling = NullValueHandling.Ignore)] Chart Chart
);