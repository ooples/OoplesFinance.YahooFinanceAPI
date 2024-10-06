namespace OoplesFinance.YahooFinanceAPI.Models;

[Serializable]
public class CapitalGainDataRoot
{
    [JsonProperty("chart")]
    public Chart? Chart { get; set; }
}