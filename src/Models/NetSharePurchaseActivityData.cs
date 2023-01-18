namespace OoplesFinance.YahooFinanceAPI.Models;

public class BuyInfoCount
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class BuyInfoShares
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class BuyPercentInsiderShares
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class NetInfoCount
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class NetInfoShares
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class NetPercentInsiderShares
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class NetSharePurchaseActivity
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("buyInfoCount")] 
    public BuyInfoCount BuyInfoCount { get; set; } = new();

    [JsonPropertyName("buyInfoShares")] 
    public BuyInfoShares BuyInfoShares { get; set; } = new();

    [JsonPropertyName("buyPercentInsiderShares")] 
    public BuyPercentInsiderShares BuyPercentInsiderShares { get; set; } = new();

    [JsonPropertyName("sellInfoCount")] 
    public SellInfoCount SellInfoCount { get; set; } = new();

    [JsonPropertyName("sellInfoShares")] 
    public SellInfoShares SellInfoShares { get; set; } = new();

    [JsonPropertyName("sellPercentInsiderShares")] 
    public SellPercentInsiderShares SellPercentInsiderShares { get; set; } = new();

    [JsonPropertyName("netInfoCount")] 
    public NetInfoCount NetInfoCount { get; set; } = new();

    [JsonPropertyName("netInfoShares")] 
    public NetInfoShares NetInfoShares { get; set; } = new();

    [JsonPropertyName("netPercentInsiderShares")] 
    public NetPercentInsiderShares NetPercentInsiderShares { get; set; } = new();

    [JsonPropertyName("totalInsiderShares")] 
    public TotalInsiderShares TotalInsiderShares { get; set; } = new();
}

public class NetSharePurchaseActivityQuoteSummary
{
    [JsonPropertyName("result")] 
    public List<NetSharePurchaseActivityResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class NetSharePurchaseActivityResult
{
    [JsonPropertyName("netSharePurchaseActivity")] 
    public NetSharePurchaseActivity NetSharePurchaseActivity { get; set; } = new();
}

public class NetSharePurchaseActivityData
{
    [JsonPropertyName("quoteSummary")]
    public NetSharePurchaseActivityQuoteSummary QuoteSummary { get; set; } = new();
}

public class SellInfoCount
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class SellInfoShares
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")] 
    public string LongFmt { get; set; } = string.Empty;
}

public class SellPercentInsiderShares
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;
}

public class TotalInsiderShares
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")] 
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}