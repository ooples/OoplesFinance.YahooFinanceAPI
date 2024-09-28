
namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class StockSplitHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var stockSplitData = JsonConvert.DeserializeObject<StockSplitRoot>(jsonData);

        if (stockSplitData != null && stockSplitData.Chart?.Result != null)
        {
            var results = stockSplitData.Chart.Result.Cast<T>();

            return results;
        }

        return [];
    }
}