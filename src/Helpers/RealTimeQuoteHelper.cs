namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class RealTimeQuoteHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Real-time Quote data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var realTimeQuoteData = JsonConvert.DeserializeObject<RealTimeQuoteData>(jsonData);

        return realTimeQuoteData != null ? (IEnumerable<T>)realTimeQuoteData.QuoteResponse.Results : [];
    }
}
