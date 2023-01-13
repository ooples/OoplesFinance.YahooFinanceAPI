using OoplesFinance.YahooFinanceAPI.Enums;
using static OoplesFinance.YahooFinanceAPI.YahooClient;

var startDate = DateTime.Now.AddYears(-1);
var symbol = "GOOG";

var historicalDataList = await GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);
var capitalGainList = await GetCapitalGainDataAsync(symbol, DataFrequency.Monthly, startDate);
var dividendList = await GetDividendDataAsync(symbol, DataFrequency.Weekly, startDate);
var stockSplitList = await GetStockSplitDataAsync(symbol, DataFrequency.Monthly, startDate);
var topTrendingList = await GetTopTrendingStocksAsync(Country.UnitedStates, 10);

Console.WriteLine();