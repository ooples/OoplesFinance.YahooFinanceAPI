namespace OoplesFinance.YahooFinanceAPI.Models;

public class Ask
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class AskSize
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class AverageDailyVolume10Day
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class AverageVolume
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class AverageVolume10days
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class BetaSummary
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class Bid
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class BidSize
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class CirculatingSupply
{
}

public class DayHigh
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class DayLow
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class DividendRate
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class DividendYield
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ExDividendDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ExpireDate
{
}

public class FiftyDayAverage
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FiftyTwoWeekHigh
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FiftyTwoWeekLow
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class FiveYearAvgDividendYield
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class MarketCap
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class MaxSupply
{
}

public class NavPrice
{
}

public class Open
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class OpenInterest
{
}

public class PayoutRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PreviousClose
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PriceHintSummary
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class PriceToSalesTrailing12Months
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class QuoteSummary
{
    [JsonPropertyName("result")]
    public List<ResultSummary> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class RegularMarketDayHigh
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RegularMarketDayLow
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RegularMarketOpen
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RegularMarketPreviousClose
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class RegularMarketVolume
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class ResultSummary
{
    [JsonPropertyName("summaryDetail")]
    public SummaryDetail SummaryDetail { get; set; } = new();
}

public class SummaryData
{
    [JsonPropertyName("quoteSummary")]
    public QuoteSummary QuoteSummary { get; set; } = new();
}

public class StrikePrice
{
}

public class SummaryDetail
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("priceHint")]
    public PriceHint PriceHint { get; set; } = new();

    [JsonPropertyName("previousClose")]
    public PreviousClose PreviousClose { get; set; } = new();

    [JsonPropertyName("open")]
    public Open Open { get; set; } = new();

    [JsonPropertyName("dayLow")] 
    public DayLow DayLow { get; set; } = new();

    [JsonPropertyName("dayHigh")]
    public DayHigh DayHigh { get; set; } = new();

    [JsonPropertyName("regularMarketPreviousClose")]
    public RegularMarketPreviousClose RegularMarketPreviousClose { get; set; } = new();

    [JsonPropertyName("regularMarketOpen")]
    public RegularMarketOpen RegularMarketOpen { get; set; } = new();

    [JsonPropertyName("regularMarketDayLow")]
    public RegularMarketDayLow RegularMarketDayLow { get; set; } = new();

    [JsonPropertyName("regularMarketDayHigh")]
    public RegularMarketDayHigh RegularMarketDayHigh { get; set; } = new();

    [JsonPropertyName("dividendRate")]
    public DividendRate DividendRate { get; set; } = new();

    [JsonPropertyName("dividendYield")]
    public DividendYield DividendYield { get; set; } = new();

    [JsonPropertyName("exDividendDate")]
    public ExDividendDate ExDividendDate { get; set; } = new();

    [JsonPropertyName("payoutRatio")]
    public PayoutRatio PayoutRatio { get; set; } = new();

    [JsonPropertyName("fiveYearAvgDividendYield")]
    public FiveYearAvgDividendYield FiveYearAvgDividendYield { get; set; } = new();

    [JsonPropertyName("beta")]
    public Beta Beta { get; set; } = new();

    [JsonPropertyName("trailingPE")]
    public TrailingPE TrailingPE { get; set; } = new();

    [JsonPropertyName("forwardPE")]
    public ForwardPE ForwardPE { get; set; } = new();

    [JsonPropertyName("volume")]
    public Volume Volume { get; set; } = new();

    [JsonPropertyName("regularMarketVolume")]
    public RegularMarketVolume RegularMarketVolume { get; set; } = new();

    [JsonPropertyName("averageVolume")]
    public AverageVolume AverageVolume { get; set; } = new();

    [JsonPropertyName("averageVolume10days")]
    public AverageVolume10days AverageVolume10days { get; set; } = new();

    [JsonPropertyName("averageDailyVolume10Day")]
    public AverageDailyVolume10Day AverageDailyVolume10Day { get; set; } = new();

    [JsonPropertyName("bid")]
    public Bid Bid { get; set; } = new();

    [JsonPropertyName("ask")]
    public Ask Ask { get; set; } = new();

    [JsonPropertyName("bidSize")]
    public BidSize BidSize { get; set; } = new();

    [JsonPropertyName("askSize")]
    public AskSize AskSize { get; set; } = new();

    [JsonPropertyName("marketCap")]
    public MarketCap MarketCap { get; set; } = new();

    [JsonPropertyName("yield")]
    public Yield Yield { get; set; } = new();

    [JsonPropertyName("ytdReturn")]
    public YtdReturnSummary YtdReturn { get; set; } = new();

    [JsonPropertyName("totalAssets")]
    public TotalAssetsSummary TotalAssets { get; set; } = new();

    [JsonPropertyName("expireDate")]
    public ExpireDate ExpireDate { get; set; } = new();

    [JsonPropertyName("strikePrice")]
    public StrikePrice StrikePrice { get; set; } = new();

    [JsonPropertyName("openInterest")]
    public OpenInterest OpenInterest { get; set; } = new();

    [JsonPropertyName("fiftyTwoWeekLow")]
    public FiftyTwoWeekLow FiftyTwoWeekLow { get; set; } = new();

    [JsonPropertyName("fiftyTwoWeekHigh")]
    public FiftyTwoWeekHigh FiftyTwoWeekHigh { get; set; } = new();

    [JsonPropertyName("priceToSalesTrailing12Months")]
    public PriceToSalesTrailing12Months PriceToSalesTrailing12Months { get; set; } = new();

    [JsonPropertyName("fiftyDayAverage")]
    public FiftyDayAverage FiftyDayAverage { get; set; } = new();

    [JsonPropertyName("twoHundredDayAverage")]
    public TwoHundredDayAverage TwoHundredDayAverage { get; set; } = new();

    [JsonPropertyName("trailingAnnualDividendRate")]
    public TrailingAnnualDividendRate TrailingAnnualDividendRate { get; set; } = new();

    [JsonPropertyName("trailingAnnualDividendYield")]
    public TrailingAnnualDividendYield TrailingAnnualDividendYield { get; set; } = new();

    [JsonPropertyName("navPrice")]
    public NavPrice NavPrice { get; set; } = new();

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("fromCurrency")]
    public object FromCurrency { get; set; } = new();

    [JsonPropertyName("toCurrency")]
    public object ToCurrency { get; set; } = new();

    [JsonPropertyName("lastMarket")]
    public object LastMarket { get; set; } = new();

    [JsonPropertyName("coinMarketCapLink")]
    public object CoinMarketCapLink { get; set; } = new();

    [JsonPropertyName("volume24Hr")]
    public Volume24Hr Volume24Hr { get; set; } = new();

    [JsonPropertyName("volumeAllCurrencies")]
    public VolumeAllCurrencies VolumeAllCurrencies { get; set; } = new();

    [JsonPropertyName("circulatingSupply")]
    public CirculatingSupply CirculatingSupply { get; set; } = new();

    [JsonPropertyName("algorithm")]
    public object Algorithm { get; set; } = new();

    [JsonPropertyName("maxSupply")]
    public MaxSupply MaxSupply { get; set; } = new();

    [JsonPropertyName("startDate")]
    public StartDate StartDate { get; set; } = new();

    [JsonPropertyName("tradeable")]
    public bool? Tradeable { get; set; }
}

public class TrailingAnnualDividendRate
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TrailingAnnualDividendYield
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TrailingPE
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TwoHundredDayAverage
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class Volume
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class Volume24Hr
{
}

public class VolumeAllCurrencies
{
}

public class YtdReturn
{
}