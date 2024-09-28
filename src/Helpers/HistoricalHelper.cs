
namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class HistoricalHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Financial Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var historicalData = JsonConvert.DeserializeObject<HistoricalDataRoot>(jsonData);

        if (historicalData != null && historicalData.Chart?.Result != null)
        {
            var quotes = historicalData.Chart.Result.SelectMany(x => x.Indicators.Quote).Cast<T>();

            return quotes;
        }

        return [];
    }
}