
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
            var result = historicalData.Chart.Result.Cast<T>();

            return result;
        }

        return [];
    }
}