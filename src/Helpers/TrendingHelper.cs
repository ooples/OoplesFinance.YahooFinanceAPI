using OoplesFinance.YahooFinanceAPI.Models;
namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class TrendingHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Trending Data
    /// </summary>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<string> ParseYahooJsonData(string jsonData)
    {
        var rawTrendingData = JsonSerializer.Deserialize<TrendingData>(jsonData);

        return rawTrendingData != null ? rawTrendingData.Finance.Result.First().Quotes.Select(x => x.Symbol) : Enumerable.Empty<string>();
    }
}
