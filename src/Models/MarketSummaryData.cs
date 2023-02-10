namespace OoplesFinance.YahooFinanceAPI.Models;

public record MarketSummaryResponse(
    [property: JsonProperty("result")] IReadOnlyList<MarketSummaryResult> Results,
    [property: JsonProperty("error")] object Error
);

public record RegularMarketTime(
    [property: JsonProperty("raw")] int? Raw,
    [property: JsonProperty("fmt")] string Fmt
);

public record MarketSummaryResult(
    [property: JsonProperty("fullExchangeName")] string FullExchangeName,
    [property: JsonProperty("exchangeTimezoneName")] string ExchangeTimezoneName,
    [property: JsonProperty("symbol")] string Symbol,
    [property: JsonProperty("regularMarketChange")] RegularMarketChange RegularMarketChange,
    [property: JsonProperty("gmtOffSetMilliseconds")] int? GmtOffSetMilliseconds,
    [property: JsonProperty("exchangeDataDelayedBy")] int? ExchangeDataDelayedBy,
    [property: JsonProperty("language")] string Language,
    [property: JsonProperty("regularMarketTime")] RegularMarketTime RegularMarketTime,
    [property: JsonProperty("exchangeTimezoneShortName")] string ExchangeTimezoneShortName,
    [property: JsonProperty("regularMarketChangePercent")] RegularMarketChangePercent RegularMarketChangePercent,
    [property: JsonProperty("quoteType")] string QuoteType,
    [property: JsonProperty("marketState")] string MarketState,
    [property: JsonProperty("regularMarketPrice")] RegularMarketPrice RegularMarketPrice,
    [property: JsonProperty("market")] string Market,
    [property: JsonProperty("quoteSourceName")] string QuoteSourceName,
    [property: JsonProperty("priceHint")] int? PriceHint,
    [property: JsonProperty("tradeable")] bool? Tradeable,
    [property: JsonProperty("sourceInterval")] int? SourceInterval,
    [property: JsonProperty("exchange")] string Exchange,
    [property: JsonProperty("shortName")] string ShortName,
    [property: JsonProperty("region")] string Region,
    [property: JsonProperty("triggerable")] bool? Triggerable,
    [property: JsonProperty("regularMarketPreviousClose")] RegularMarketPreviousClose RegularMarketPreviousClose,
    [property: JsonProperty("headSymbolAsString")] string HeadSymbolAsString,
    [property: JsonProperty("currency")] string Currency,
    [property: JsonProperty("longName")] string LongName
);

public record MarketSummaryData(
    [property: JsonProperty("marketSummaryResponse")] MarketSummaryResponse MarketSummaryResponse
);