namespace OoplesFinance.YahooFinanceAPI.Models;

public class _52WeekChange
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class AnnualHoldingsTurnover
{
}

public class AnnualReportExpenseRatio
{
}

public class Beta
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class Beta3Year
{
}

public class BookValue
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class DateShortInterest
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class KeyStatistics
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("priceHint")] 
    public PriceHint PriceHint { get; set; } = new();

    [JsonPropertyName("enterpriseValue")] 
    public EnterpriseValue EnterpriseValue { get; set; } = new();

    [JsonPropertyName("forwardPE")] 
    public ForwardPE ForwardPE { get; set; } = new();

    [JsonPropertyName("profitMargins")] 
    public ProfitMargins ProfitMargins { get; set; } = new();

    [JsonPropertyName("floatShares")] 
    public FloatShares FloatShares { get; set; } = new();

    [JsonPropertyName("sharesOutstanding")] 
    public SharesOutstanding SharesOutstanding { get; set; } = new();

    [JsonPropertyName("sharesShort")] 
    public SharesShort SharesShort { get; set; } = new();

    [JsonPropertyName("sharesShortPriorMonth")] 
    public SharesShortPriorMonth SharesShortPriorMonth { get; set; } = new();

    [JsonPropertyName("sharesShortPreviousMonthDate")] 
    public SharesShortPreviousMonthDate SharesShortPreviousMonthDate { get; set; } = new();

    [JsonPropertyName("dateShortInterest")] 
    public DateShortInterest DateShortInterest { get; set; } = new();

    [JsonPropertyName("sharesPercentSharesOut")] 
    public SharesPercentSharesOut SharesPercentSharesOut { get; set; } = new();

    [JsonPropertyName("heldPercentInsiders")] 
    public HeldPercentInsiders HeldPercentInsiders { get; set; } = new();

    [JsonPropertyName("heldPercentInstitutions")] 
    public HeldPercentInstitutions HeldPercentInstitutions { get; set; } = new();

    [JsonPropertyName("shortRatio")] 
    public ShortRatio ShortRatio { get; set; } = new();

    [JsonPropertyName("shortPercentOfFloat")] 
    public ShortPercentOfFloat ShortPercentOfFloat { get; set; } = new();

    [JsonPropertyName("beta")] 
    public Beta Beta { get; set; } = new();

    [JsonPropertyName("impliedSharesOutstanding")] 
    public ImpliedSharesOutstanding ImpliedSharesOutstanding { get; set; } = new();

    [JsonPropertyName("morningStarOverallRating")] 
    public MorningStarOverallRating MorningStarOverallRating { get; set; } = new();

    [JsonPropertyName("morningStarRiskRating")] 
    public MorningStarRiskRating MorningStarRiskRating { get; set; } = new();

    [JsonPropertyName("category")] 
    public object Category { get; set; } = new();

    [JsonPropertyName("bookValue")] 
    public BookValue BookValue { get; set; } = new();

    [JsonPropertyName("priceToBook")] 
    public PriceToBook PriceToBook { get; set; } = new();

    [JsonPropertyName("annualReportExpenseRatio")] 
    public AnnualReportExpenseRatio AnnualReportExpenseRatio { get; set; } = new();

    [JsonPropertyName("ytdReturn")] 
    public YtdReturn YtdReturn { get; set; } = new();

    [JsonPropertyName("beta3Year")] 
    public Beta3Year Beta3Year { get; set; } = new();

    [JsonPropertyName("totalAssets")] 
    public TotalAssets TotalAssets { get; set; } = new();

    [JsonPropertyName("yield")] 
    public Yield Yield { get; set; } = new();

    [JsonPropertyName("fundFamily")] 
    public object FundFamily { get; set; } = new();

    [JsonPropertyName("fundInceptionDate")] 
    public FundInceptionDate FundInceptionDate { get; set; } = new();

    [JsonPropertyName("legalType")]
    public object LegalType { get; set; } = new();

    [JsonPropertyName("threeYearAverageReturn")] 
    public ThreeYearAverageReturn ThreeYearAverageReturn { get; set; } = new();

    [JsonPropertyName("fiveYearAverageReturn")] 
    public FiveYearAverageReturn FiveYearAverageReturn { get; set; } = new();

    [JsonPropertyName("priceToSalesTrailing12Months")] 
    public PriceToSalesTrailing12Months PriceToSalesTrailing12Months { get; set; } = new();

    [JsonPropertyName("lastFiscalYearEnd")] 
    public LastFiscalYearEnd LastFiscalYearEnd { get; set; } = new();

    [JsonPropertyName("nextFiscalYearEnd")] 
    public NextFiscalYearEnd NextFiscalYearEnd { get; set; } = new();

    [JsonPropertyName("mostRecentQuarter")] 
    public MostRecentQuarter MostRecentQuarter { get; set; } = new();

    [JsonPropertyName("earningsQuarterlyGrowth")] 
    public EarningsQuarterlyGrowth EarningsQuarterlyGrowth { get; set; } = new();

    [JsonPropertyName("revenueQuarterlyGrowth")] 
    public RevenueQuarterlyGrowth RevenueQuarterlyGrowth { get; set; } = new();

    [JsonPropertyName("netIncomeToCommon")] 
    public NetIncomeToCommon NetIncomeToCommon { get; set; } = new();

    [JsonPropertyName("trailingEps")] 
    public TrailingEps TrailingEps { get; set; } = new();

    [JsonPropertyName("forwardEps")] 
    public ForwardEps ForwardEps { get; set; } = new();

    [JsonPropertyName("pegRatio")] 
    public PegRatio PegRatio { get; set; } = new();

    [JsonPropertyName("lastSplitFactor")] 
    public string LastSplitFactor { get; set; } = string.Empty;

    [JsonPropertyName("lastSplitDate")] 
    public LastSplitDate LastSplitDate { get; set; } = new();

    [JsonPropertyName("enterpriseToRevenue")] 
    public EnterpriseToRevenue EnterpriseToRevenue { get; set; } = new();

    [JsonPropertyName("enterpriseToEbitda")] 
    public EnterpriseToEbitda EnterpriseToEbitda { get; set; } = new();

    [JsonPropertyName("52WeekChange")] 
    public _52WeekChange _52WeekChange { get; set; } = new();

    [JsonPropertyName("SandP52WeekChange")] 
    public SandP52WeekChange SandP52WeekChange { get; set; } = new();

    [JsonPropertyName("lastDividendValue")] 
    public LastDividendValue LastDividendValue { get; set; } = new();

    [JsonPropertyName("lastDividendDate")] 
    public LastDividendDate LastDividendDate { get; set; } = new();

    [JsonPropertyName("lastCapGain")] 
    public LastCapGain LastCapGain { get; set; } = new();

    [JsonPropertyName("annualHoldingsTurnover")]
    public AnnualHoldingsTurnover AnnualHoldingsTurnover { get; set; } = new();
}

public class EarningsQuarterlyGrowth
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class EnterpriseToEbitda
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class EnterpriseToRevenue
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class EnterpriseValue
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class FiveYearAverageReturn
{
}

public class FloatShares
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class ForwardEps
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ForwardPE
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class FundInceptionDate
{
}

public class HeldPercentInsiders
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class HeldPercentInstitutions
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ImpliedSharesOutstanding
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public object Fmt { get; set; } = new();

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class LastCapGain
{
}

public class LastDividendDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class LastDividendValue
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class LastFiscalYearEnd
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class LastSplitDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class MorningStarOverallRating
{
}

public class MorningStarRiskRating
{
}

public class MostRecentQuarter
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class NetIncomeToCommon
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class NextFiscalYearEnd
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class PegRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PriceHint
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class PriceToBook
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PriceToSalesTrailing12Months
{
}

public class ProfitMargins
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class QuoteSummary
{
    [JsonPropertyName("result")] 
    public List<KeyStatisticResult> Result { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class KeyStatisticResult
{
    [JsonPropertyName("defaultKeyStatistics")]
    public KeyStatistics DefaultKeyStatistics { get; set; } = new();
}

public class RevenueQuarterlyGrowth
{
}

public class KeyStatisticData
{
    [JsonPropertyName("quoteSummary")]
    public QuoteSummary QuoteSummary { get; set; } = new();
}

public class SandP52WeekChange
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class SharesOutstanding
{
    [JsonPropertyName("raw")]
    public long? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class SharesPercentSharesOut
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class SharesShort
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class SharesShortPreviousMonthDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class SharesShortPriorMonth
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class ShortPercentOfFloat
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ShortRatio
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class ThreeYearAverageReturn
{
}

public class TotalAssets
{
}

public class TrailingEps
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class Yield
{
}

public class YtdReturn
{
}