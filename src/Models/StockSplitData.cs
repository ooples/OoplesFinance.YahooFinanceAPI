namespace OoplesFinance.YahooFinanceAPI.Models;

[Serializable]
public class StockSplitData
{
    public DateTime Date { get; set; }
    public string StockSplit { get; set; } = default!;
}
