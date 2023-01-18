namespace OoplesFinance.YahooFinanceAPI.Models;

public class AverageDailyVolume3Month
{
}

public class PostMarketChange
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PostMarketChangePercent
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PostMarketPrice
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PreMarketChange
{
}

public class PreMarketPrice
{
}

public class Price
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("preMarketChange")]
    public PreMarketChange PreMarketChange { get; set; } = new();

    [JsonPropertyName("preMarketPrice")]
    public PreMarketPrice PreMarketPrice { get; set; } = new();

    [JsonPropertyName("preMarketSource")]
    public string PreMarketSource { get; set; } = string.Empty;

    [JsonPropertyName("postMarketChangePercent")] 
    public PostMarketChangePercent PostMarketChangePercent { get; set; } = new();

    [JsonPropertyName("postMarketChange")] 
    public PostMarketChange PostMarketChange { get; set; } = new();

    [JsonPropertyName("postMarketTime")]
    public int? PostMarketTime { get; set; }

    [JsonPropertyName("postMarketPrice")] 
    public PostMarketPrice PostMarketPrice { get; set; } = new();

    [JsonPropertyName("postMarketSource")]
    public string PostMarketSource { get; set; } = string.Empty;

    [JsonPropertyName("regularMarketChangePercent")] 
    public RegularMarketChangePercent RegularMarketChangePercent { get; set; } = new();

    [JsonPropertyName("regularMarketChange")] 
    public RegularMarketChange RegularMarketChange { get; set; } = new();

    [JsonPropertyName("regularMarketTime")]
    public int? RegularMarketTime { get; set; }

    [JsonPropertyName("priceHint")] 
    public PriceHint PriceHint { get; set; } = new();

    [JsonPropertyName("regularMarketPrice")] 
    public RegularMarketPrice RegularMarketPrice { get; set; } = new();

    [JsonPropertyName("regularMarketDayHigh")] 
    public RegularMarketDayHigh RegularMarketDayHigh { get; set; } = new();

    [JsonPropertyName("regularMarketDayLow")] 
    public RegularMarketDayLow RegularMarketDayLow { get; set; } = new();

    [JsonPropertyName("regularMarketVolume")] 
    public RegularMarketVolume RegularMarketVolume { get; set; } = new();

    [JsonPropertyName("averageDailyVolume10Day")] 
    public AverageDailyVolume10Day AverageDailyVolume10Day { get; set; } = new();

    [JsonPropertyName("averageDailyVolume3Month")] 
    public AverageDailyVolume3Month AverageDailyVolume3Month { get; set; } = new();

    [JsonPropertyName("regularMarketPreviousClose")] 
    public RegularMarketPreviousClose RegularMarketPreviousClose { get; set; } = new();

    [JsonPropertyName("regularMarketSource")]
    public string RegularMarketSource { get; set; } = string.Empty;

    [JsonPropertyName("regularMarketOpen")] 
    public RegularMarketOpen RegularMarketOpen { get; set; } = new();

    [JsonPropertyName("strikePrice")]
    public StrikePrice StrikePrice { get; set; } = new();

    [JsonPropertyName("openInterest")]
    public OpenInterest OpenInterest { get; set; } = new();

    [JsonPropertyName("exchange")] 
    public string Exchange { get; set; } = string.Empty;

    [JsonPropertyName("exchangeName")] 
    public string ExchangeName { get; set; } = string.Empty;

    [JsonPropertyName("exchangeDataDelayedBy")]
    public int? ExchangeDataDelayedBy { get; set; }

    [JsonPropertyName("marketState")] 
    public string MarketState { get; set; } = string.Empty;

    [JsonPropertyName("quoteType")] 
    public string QuoteType { get; set; } = string.Empty;

    [JsonPropertyName("symbol")] 
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("underlyingSymbol")]
    public object UnderlyingSymbol { get; set; } = new();

    [JsonPropertyName("shortName")] 
    public string ShortName { get; set; } = string.Empty;

    [JsonPropertyName("longName")] 
    public string LongName { get; set; } = string.Empty;

    [JsonPropertyName("currency")] 
    public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("quoteSourceName")]
    public string QuoteSourceName { get; set; } = string.Empty;

    [JsonPropertyName("currencySymbol")]
    public string CurrencySymbol { get; set; } = string.Empty;

    [JsonPropertyName("fromCurrency")] 
    public object FromCurrency { get; set; } = new();

    [JsonPropertyName("lastMarket")]
    public object LastMarket { get; set; } = new();

    [JsonPropertyName("volume24Hr")] 
    public Volume24Hr Volume24Hr { get; set; } = new();

    [JsonPropertyName("volumeAllCurrencies")]
    public VolumeAllCurrencies VolumeAllCurrencies { get; set; } = new();

    [JsonPropertyName("circulatingSupply")]
    public CirculatingSupply CirculatingSupply { get; set; } = new();

    [JsonPropertyName("marketCap")]
    public MarketCap MarketCap { get; set; } = new();
}

public class PriceQuoteSummary
{
    [JsonPropertyName("result")]
    public List<PriceResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class RegularMarketChange
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RegularMarketChangePercent
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RegularMarketPrice
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PriceResult
{
    [JsonPropertyName("price")]
    public Price Price { get; set; } = new();
}

public class PriceData
{
    [JsonPropertyName("quoteSummary")]
    public PriceQuoteSummary QuoteSummary { get; set; } = new();
}