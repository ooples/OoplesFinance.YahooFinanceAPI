

namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class CapitalGainHelper : YahooJsonBase
{
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var capitalGain = JsonConvert.DeserializeObject<CapitalGainDataRoot>(jsonData);

        if (capitalGain != null && capitalGain.Chart?.Result != null)
        {
            var result = capitalGain.Chart.Result.Cast<T>();

            return result;
        }

        return [];
    }
}
