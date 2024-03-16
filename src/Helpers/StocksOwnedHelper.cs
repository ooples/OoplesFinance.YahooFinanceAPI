namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class StocksOwnedHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Stocks Owned data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var stocksOwned = JsonConvert.DeserializeObject<StocksOwnedData>(jsonData);

        return stocksOwned != null ? (IEnumerable<T>)stocksOwned.Finance.Results : [];
    }
}
