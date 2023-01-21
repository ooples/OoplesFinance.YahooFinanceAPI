namespace OoplesFinance.YahooFinanceAPI.Models;

public class QuoteResponse
{
    [JsonPropertyName("result")] 
    public List<RealTimeQuoteResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class RealTimeQuoteResult
{
    [JsonPropertyName("language")] 
    public string Language { get; set; } = string.Empty;

    [JsonPropertyName("region")] 
    public string Region { get; set; } = string.Empty;

    [JsonPropertyName("quoteType")] 
    public string QuoteType { get; set; } = string.Empty;

    [JsonPropertyName("typeDisp")] 
    public string TypeDisp { get; set; } = string.Empty;

    [JsonPropertyName("quoteSourceName")] 
    public string QuoteSourceName { get; set; } = string.Empty;

    [JsonPropertyName("triggerable")]
    public bool? Triggerable { get; set; }

    [JsonPropertyName("customPriceAlertConfidence")] 
    public string CustomPriceAlertConfidence { get; set; } = string.Empty;

    [JsonPropertyName("currency")] 
    public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("fiftyTwoWeekHighChange")]
    public double? FiftyTwoWeekHighChange { get; set; }

    [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
    public double? FiftyTwoWeekHighChangePercent { get; set; }

    [JsonPropertyName("fiftyTwoWeekLow")]
    public double? FiftyTwoWeekLow { get; set; }

    [JsonPropertyName("fiftyTwoWeekHigh")]
    public double? FiftyTwoWeekHigh { get; set; }

    [JsonPropertyName("dividendDate")]
    public int? DividendDate { get; set; }

    [JsonPropertyName("earningsTimestamp")]
    public int? EarningsTimestamp { get; set; }

    [JsonPropertyName("earningsTimestampStart")]
    public int? EarningsTimestampStart { get; set; }

    [JsonPropertyName("earningsTimestampEnd")]
    public int? EarningsTimestampEnd { get; set; }

    [JsonPropertyName("trailingAnnualDividendRate")]
    public double? TrailingAnnualDividendRate { get; set; }

    [JsonPropertyName("trailingPE")]
    public double? TrailingPE { get; set; }

    [JsonPropertyName("trailingAnnualDividendYield")]
    public double? TrailingAnnualDividendYield { get; set; }

    [JsonPropertyName("epsTrailingTwelveMonths")]
    public double? EpsTrailingTwelveMonths { get; set; }

    [JsonPropertyName("epsForward")]
    public double? EpsForward { get; set; }

    [JsonPropertyName("epsCurrentYear")]
    public double? EpsCurrentYear { get; set; }

    [JsonPropertyName("priceEpsCurrentYear")]
    public double? PriceEpsCurrentYear { get; set; }

    [JsonPropertyName("sharesOutstanding")]
    public long? SharesOutstanding { get; set; }

    [JsonPropertyName("bookValue")]
    public double? BookValue { get; set; }

    [JsonPropertyName("fiftyDayAverage")]
    public double? FiftyDayAverage { get; set; }

    [JsonPropertyName("fiftyDayAverageChange")]
    public double? FiftyDayAverageChange { get; set; }

    [JsonPropertyName("fiftyDayAverageChangePercent")]
    public double? FiftyDayAverageChangePercent { get; set; }

    [JsonPropertyName("twoHundredDayAverage")]
    public double? TwoHundredDayAverage { get; set; }

    [JsonPropertyName("twoHundredDayAverageChange")]
    public double? TwoHundredDayAverageChange { get; set; }

    [JsonPropertyName("twoHundredDayAverageChangePercent")]
    public double? TwoHundredDayAverageChangePercent { get; set; }

    [JsonPropertyName("marketCap")]
    public long? MarketCap { get; set; }

    [JsonPropertyName("forwardPE")]
    public double? ForwardPE { get; set; }

    [JsonPropertyName("priceToBook")]
    public double? PriceToBook { get; set; }

    [JsonPropertyName("sourceInterval")]
    public int? SourceInterval { get; set; }

    [JsonPropertyName("exchangeDataDelayedBy")]
    public int? ExchangeDataDelayedBy { get; set; }

    [JsonPropertyName("averageAnalystRating")] public string AverageAnalystRating { get; set; } = string.Empty;

    [JsonPropertyName("tradeable")]
    public bool? Tradeable { get; set; }

    [JsonPropertyName("cryptoTradeable")]
    public bool? CryptoTradeable { get; set; }

    [JsonPropertyName("regularMarketChangePercent")]
    public double? RegularMarketChangePercent { get; set; }

    [JsonPropertyName("regularMarketPrice")]
    public double? RegularMarketPrice { get; set; }

    [JsonPropertyName("marketState")] 
    public string MarketState { get; set; } = string.Empty;

    [JsonPropertyName("exchange")] 
    public string Exchange { get; set; } = string.Empty;

    [JsonPropertyName("shortName")] 
    public string ShortName { get; set; } = string.Empty;

    [JsonPropertyName("longName")] 
    public string LongName { get; set; } = string.Empty;

    [JsonPropertyName("messageBoardId")] 
    public string MessageBoardId { get; set; } = string.Empty;

    [JsonPropertyName("exchangeTimezoneName")] 
    public string ExchangeTimezoneName { get; set; } = string.Empty;

    [JsonPropertyName("exchangeTimezoneShortName")] 
    public string ExchangeTimezoneShortName { get; set; } = string.Empty;

    [JsonPropertyName("gmtOffSetMilliseconds")]
    public int? GmtOffSetMilliseconds { get; set; }

    [JsonPropertyName("market")] 
    public string Market { get; set; } = string.Empty;

    [JsonPropertyName("esgPopulated")]
    public bool? EsgPopulated { get; set; }

    [JsonPropertyName("firstTradeDateMilliseconds")]
    public object FirstTradeDateMilliseconds { get; set; } = new();

    [JsonPropertyName("priceHint")]
    public int? PriceHint { get; set; }

    [JsonPropertyName("postMarketChangePercent")]
    public double? PostMarketChangePercent { get; set; }

    [JsonPropertyName("postMarketTime")]
    public int? PostMarketTime { get; set; }

    [JsonPropertyName("postMarketPrice")]
    public double? PostMarketPrice { get; set; }

    [JsonPropertyName("postMarketChange")]
    public double? PostMarketChange { get; set; }

    [JsonPropertyName("regularMarketChange")]
    public double? RegularMarketChange { get; set; }

    [JsonPropertyName("regularMarketTime")]
    public int? RegularMarketTime { get; set; }

    [JsonPropertyName("regularMarketDayHigh")]
    public double? RegularMarketDayHigh { get; set; }

    [JsonPropertyName("regularMarketDayRange")] 
    public string RegularMarketDayRange { get; set; } = string.Empty;

    [JsonPropertyName("regularMarketDayLow")]
    public double? RegularMarketDayLow { get; set; }

    [JsonPropertyName("regularMarketVolume")]
    public int? RegularMarketVolume { get; set; }

    [JsonPropertyName("regularMarketPreviousClose")]
    public double? RegularMarketPreviousClose { get; set; }

    [JsonPropertyName("bid")]
    public double? Bid { get; set; }

    [JsonPropertyName("ask")]
    public double? Ask { get; set; }

    [JsonPropertyName("bidSize")]
    public int? BidSize { get; set; }

    [JsonPropertyName("askSize")]
    public int? AskSize { get; set; }

    [JsonPropertyName("fullExchangeName")] 
    public string FullExchangeName { get; set; } = string.Empty;

    [JsonPropertyName("financialCurrency")] 
    public string FinancialCurrency { get; set; } = string.Empty;

    [JsonPropertyName("regularMarketOpen")]
    public double? RegularMarketOpen { get; set; }

    [JsonPropertyName("averageDailyVolume3Month")]
    public int? AverageDailyVolume3Month { get; set; }

    [JsonPropertyName("averageDailyVolume10Day")]
    public int? AverageDailyVolume10Day { get; set; }

    [JsonPropertyName("fiftyTwoWeekLowChange")]
    public double? FiftyTwoWeekLowChange { get; set; }

    [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
    public double? FiftyTwoWeekLowChangePercent { get; set; }

    [JsonPropertyName("fiftyTwoWeekRange")] 
    public string FiftyTwoWeekRange { get; set; } = string.Empty;

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;
}

public class RealTimeQuoteData
{
    [JsonPropertyName("quoteResponse")]
    public QuoteResponse QuoteResponse { get; set; } = new();
}