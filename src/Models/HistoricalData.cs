namespace OoplesFinance.YahooFinanceAPI.Models;

[Serializable]

public class HistoricalDataRoot
{
    [JsonProperty("chart")]
    public Chart? Chart { get; set; }
}