
namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class DividendHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var dividendData = JsonConvert.DeserializeObject<DividendRoot>(jsonData);

        if (dividendData != null && dividendData.Chart?.Result != null)
        {
            var results = dividendData.Chart.Result.Cast<T>();

            return results;
        }

        return [];
    }
}