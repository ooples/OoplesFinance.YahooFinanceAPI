namespace OoplesFinance.YahooFinanceAPI.Models;

public class InsiderTransactions
{
    [JsonPropertyName("transactions")]
    public List<Transaction> Transactions { get; set; } = new();

    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

public class InsiderTransactionQuoteSummary
{
    [JsonPropertyName("result")]
    public List<InsiderTransactionResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class InsiderTransactionResult
{
    [JsonPropertyName("insiderTransactions")] 
    public InsiderTransactions InsiderTransactions { get; set; } = new();
}

public class InsiderTransactionData
{
    [JsonPropertyName("quoteSummary")] 
    public InsiderTransactionQuoteSummary QuoteSummary { get; set; } = new();
}

public class Shares
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}

public class StartDate
{
    [JsonPropertyName("raw")]
    public int? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class Transaction
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("shares")]
    public Shares Shares { get; set; } = new();

    [JsonPropertyName("value")]
    public Value Value { get; set; } = new();

    [JsonPropertyName("filerUrl")]
    public string FilerUrl { get; set; } = string.Empty;

    [JsonPropertyName("transactionText")]
    public string TransactionText { get; set; } = string.Empty;

    [JsonPropertyName("filerName")]
    public string FilerName { get; set; } = string.Empty;

    [JsonPropertyName("filerRelation")]
    public string FilerRelation { get; set; } = string.Empty;

    [JsonPropertyName("moneyText")]
    public string MoneyText { get; set; } = string.Empty;

    [JsonPropertyName("startDate")]
    public StartDate StartDate { get; set; } = new();

    [JsonPropertyName("ownership")]
    public string Ownership { get; set; } = string.Empty;
}

public class Value
{
    [JsonPropertyName("raw")]
    public float? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;

    [JsonPropertyName("longFmt")]
    public string LongFmt { get; set; } = string.Empty;
}