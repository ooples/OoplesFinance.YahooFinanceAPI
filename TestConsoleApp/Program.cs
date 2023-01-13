using OoplesFinance.YahooFinanceAPI.Enums;
using static OoplesFinance.YahooFinanceAPI.YahooClient;
using System.Text.Json;
using OoplesFinance.YahooFinanceAPI.Models;
using System.Net.Http.Json;
using System.Net;

var startDate = DateTime.Now.AddYears(-1);
var symbol = "GOOG";

var historicalDataList = await GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);
var capitalGainList = await GetCapitalGainDataAsync(symbol, DataFrequency.Monthly, startDate);
var dividendList = await GetDividendDataAsync(symbol, DataFrequency.Weekly, startDate);
var stockSplitList = await GetStockSplitDataAsync(symbol, DataFrequency.Monthly, startDate);

var test2 = await GetTopTrendingStocksAsync(Country.UnitedStates, 0);

Console.WriteLine();