![Nuget](https://img.shields.io/nuget/dt/OoplesFinance.YahooFinanceAPI?style=plastic)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/OoplesFinance.YahooFinanceAPI?style=plastic)
![github](https://img.shields.io/github/license/ooples/OoplesFinance.YahooFinanceAPI?style=plastic)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/147ed8075c6048ffb3b335b445e83738)](https://app.codacy.com/gh/ooples/OoplesFinance.YahooFinanceAPI?utm_source=github.com&utm_medium=referral&utm_content=ooples/OoplesFinance.YahooFinanceAPI&utm_campaign=Badge_Grade_Settings)

## .Net Yahoo Finance API Library

This is a library for downloading free data using Yahoo Finance that is completely open source (Apache 2.0 license) and very easy to use. 
This library currently supports downloading 4 different types of stock market data at the time of this writing: 
historical/daily prices, stock splits, dividends, and capital gain information. 
We support getting daily, weekly, or monthly data for any of the above options.


### How to use this library

Here is an example to show how easy it is to use this library to get various stock market info:

```cs
using OoplesFinance.YahooFinanceAPI.Enums;
using static OoplesFinance.YahooFinanceAPI.YahooClient;

var startDate = DateTime.Now.AddYears(-1);
var symbol = "GOOG";

var historicalDataList = await GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);
var capitalGainList = await GetCapitalGainDataAsync(symbol, DataFrequency.Monthly, startDate);
var dividendList = await GetDividendDataAsync(symbol, DataFrequency.Weekly, startDate);
var stockSplitList = await GetStockSplitDataAsync(symbol, DataFrequency.Monthly, startDate);
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
