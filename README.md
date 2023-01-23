![Nuget](https://img.shields.io/nuget/dt/OoplesFinance.YahooFinanceAPI?style=plastic)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/OoplesFinance.YahooFinanceAPI?style=plastic)
![github](https://img.shields.io/github/license/ooples/OoplesFinance.YahooFinanceAPI?style=plastic)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/147ed8075c6048ffb3b335b445e83738)](https://app.codacy.com/gh/ooples/OoplesFinance.YahooFinanceAPI?utm_source=github.com&utm_medium=referral&utm_content=ooples/OoplesFinance.YahooFinanceAPI&utm_campaign=Badge_Grade_Settings)

## .Net Yahoo Finance API Library

This is a library for downloading free data using Yahoo Finance that is completely open source (Apache 2.0 license) and very easy to use. 
This library currently supports downloading 39 different types of stock market data at the time of this writing: 
historical/daily prices, stock splits, dividends, capital gains, stock recommendations, insider holders, key stats, financial data, 
insider transactions, fund ownership, major direct holders, top trending stock information, and much much more! 
Instead of listing everything, I decided it would be easier to provide examples below of every possible data type and how to use them. 
We support getting daily, weekly, or monthly data as well as many other options.


### How to use this library

Here is an example to show how easy it is to use this library to get various stock market info:

```cs
using OoplesFinance.YahooFinanceAPI;
using OoplesFinance.YahooFinanceAPI.Enums;

var startDate = DateTime.Now.AddYears(-1);
var symbol = "AAPL";
var fundSymbol = "VSMPX";
var symbols = new string[] { symbol, "MSFT", "NFLX", "TSLA", "YHOO", "SPY", "A", "AA", "GOOG", "F", "UBER", "LYFT" };

var yahooClient = new YahooClient();
var historicalDataList = await yahooClient.GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);
var capitalGainList = await yahooClient.GetCapitalGainDataAsync(symbol, DataFrequency.Monthly, startDate);
var dividendList = await yahooClient.GetDividendDataAsync(symbol, DataFrequency.Weekly, startDate);
var stockSplitList = await yahooClient.GetStockSplitDataAsync(symbol, DataFrequency.Monthly, startDate);
var topTrendingList = await yahooClient.GetTopTrendingStocksAsync(Country.UnitedStates, 10);
var recommendedList = await yahooClient.GetStockRecommendationsAsync(symbol);
var keyStatsList = await yahooClient.GetKeyStatisticsAsync(symbol);
var summaryDetailsList = await yahooClient.GetSummaryDetailsAsync(symbol);
var insiderHoldersList = await yahooClient.GetInsiderHoldersAsync(symbol);
var insiderTransactionsList = await yahooClient.GetInsiderTransactionsAsync(symbol);
var financialDataList = await yahooClient.GetFinancialDataAsync(symbol);
var institutionOwnershipList = await yahooClient.GetInstitutionOwnershipAsync(symbol);
var fundOwnershipList = await yahooClient.GetFundOwnershipAsync(symbol);
var majorDirectHoldersList = await yahooClient.GetMajorDirectHoldersAsync(symbol);
var secFilingsList = await yahooClient.GetSecFilingsAsync(symbol);
var insightsList = await yahooClient.GetInsightsAsync(symbol);
var majorHoldersBreakdownList = await yahooClient.GetMajorHoldersBreakdownAsync(symbol);
var upgradeDowngradeHistoryList = await yahooClient.GetUpgradeDowngradeHistoryAsync(symbol);
var esgScoresList = await yahooClient.GetEsgScoresAsync(symbol);
var recommendationTrendList = await yahooClient.GetRecommendationTrendAsync(symbol);
var indexTrendList = await yahooClient.GetIndexTrendAsync(symbol);
var sectorTrendList = await yahooClient.GetSectorTrendAsync(symbol);
var earningsTrendList = await yahooClient.GetEarningsTrendAsync(symbol);
var assetProfileList = await yahooClient.GetAssetProfileAsync(symbol);
var fundProfileList = await yahooClient.GetFundProfileAsync(fundSymbol);
var calendarEventsList = await yahooClient.GetCalendarEventsAsync(symbol);
var earningsList = await yahooClient.GetEarningsAsync(symbol);
var balanceSheetHistoryList = await yahooClient.GetBalanceSheetHistoryAsync(symbol);
var cashflowStatementHistoryList = await yahooClient.GetCashflowStatementHistoryAsync(symbol);
var incomeStatementHistoryList = await yahooClient.GetIncomeStatementHistoryAsync(symbol);
var earningsHistoryList = await yahooClient.GetEarningsHistoryAsync(symbol);
var quoteTypeList = await yahooClient.GetQuoteTypeAsync(symbol);
var priceList = await yahooClient.GetPriceInfoAsync(symbol);
var netSharePurchaseActivityList = await yahooClient.GetNetSharePurchaseActivityAsync(symbol);
var incomeStatementHistoryQuarterlyList = await yahooClient.GetIncomeStatementHistoryQuarterlyAsync(symbol);
var cashflowStatementHistoryQuarterlyList = await yahooClient.GetCashflowStatementHistoryQuarterlyAsync(symbol);
var balanceSheetHistoryQuarterlyList = await yahooClient.GetBalanceSheetHistoryQuarterlyAsync(symbol);
var chartInfoList = await yahooClient.GetChartInfoAsync(symbol, TimeRange._1Day, TimeInterval._1Minute);
var sparkChartInfoList = await yahooClient.GetSparkChartInfoAsync(symbols, TimeRange._1Month, TimeInterval._1Day);
var realTimeQuoteList = await yahooClient.GetRealTimeQuotesAsync(symbol);
```


### Support This Project

BTC: 36DRmZefJNW82q9pHY1kWYSZhLUWQkpgGq

ETH: 0x7D6e58754476189ffF736B63b6159D2647f74f34

DOGE: DF1nsK1nLASzmwHNAfNengBGS4w7bNyJ1e

SHIB: 0xCDe2355212764218355c9393FbE121Ae49B43382

Paypal: [https://www.paypal.me/cheatcountry](https://www.paypal.me/cheatcountry)

Patreon: [https://patreon.com/cheatcountry](https://patreon.com/cheatcountry)


### Support or Contact

Email me at cheatcountry@gmail.com for any help or support or to let me know of ways to further improve this library.
### Support or Contact

Email me at cheatcountry@gmail.com for any help or support or to let me know of ways to further improve this library.
