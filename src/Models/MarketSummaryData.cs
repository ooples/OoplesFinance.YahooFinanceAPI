namespace OoplesFinance.YahooFinanceAPI.Models;

public record MarketSummaryResponse(
    [property: JsonPropertyName("result")] IReadOnlyList<MarketSummaryResult> Results,
    [property: JsonPropertyName("error")] object Error
);

public record RegularMarketTime(
    [property: JsonPropertyName("raw")] int? Raw,
    [property: JsonPropertyName("fmt")] string Fmt
);

public record MarketSummaryResult(
    [property: JsonPropertyName("fullExchangeName")] string FullExchangeName,
    [property: JsonPropertyName("exchangeTimezoneName")] string ExchangeTimezoneName,
    [property: JsonPropertyName("symbol")] string Symbol,
    [property: JsonPropertyName("regularMarketChange")] RegularMarketChange RegularMarketChange,
    [property: JsonPropertyName("gmtOffSetMilliseconds")] int? GmtOffSetMilliseconds,
    [property: JsonPropertyName("exchangeDataDelayedBy")] int? ExchangeDataDelayedBy,
    [property: JsonPropertyName("language")] string Language,
    [property: JsonPropertyName("regularMarketTime")] RegularMarketTime RegularMarketTime,
    [property: JsonPropertyName("exchangeTimezoneShortName")] string ExchangeTimezoneShortName,
    [property: JsonPropertyName("regularMarketChangePercent")] RegularMarketChangePercent RegularMarketChangePercent,
    [property: JsonPropertyName("quoteType")] string QuoteType,
    [property: JsonPropertyName("marketState")] string MarketState,
    [property: JsonPropertyName("regularMarketPrice")] RegularMarketPrice RegularMarketPrice,
    [property: JsonPropertyName("market")] string Market,
    [property: JsonPropertyName("quoteSourceName")] string QuoteSourceName,
    [property: JsonPropertyName("priceHint")] int? PriceHint,
    [property: JsonPropertyName("tradeable")] bool? Tradeable,
    [property: JsonPropertyName("sourceInterval")] int? SourceInterval,
    [property: JsonPropertyName("exchange")] string Exchange,
    [property: JsonPropertyName("shortName")] string ShortName,
    [property: JsonPropertyName("region")] string Region,
    [property: JsonPropertyName("triggerable")] bool? Triggerable,
    [property: JsonPropertyName("regularMarketPreviousClose")] RegularMarketPreviousClose RegularMarketPreviousClose,
    [property: JsonPropertyName("headSymbolAsString")] string HeadSymbolAsString,
    [property: JsonPropertyName("currency")] string Currency,
    [property: JsonPropertyName("longName")] string LongName
);

public record MarketSummaryData(
    [property: JsonPropertyName("marketSummaryResponse")] MarketSummaryResponse MarketSummaryResponse
);