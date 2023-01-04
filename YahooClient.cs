namespace OoplesFinance.YahooFinanceAPI;

public static class YahooClient
{
    public static async Task<IEnumerable<HistoricalData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return await DownloadYahooDataAsync<HistoricalData>(symbol, DataType.HistoricalPrices, dataFrequency, startDate, endDate, includeAdjustedClose);
    }

    public static async Task<IEnumerable<DividendData>> GetDividendDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return await DownloadYahooDataAsync<DividendData>(symbol, DataType.Dividends, dataFrequency, startDate, endDate, includeAdjustedClose);
    }

    public static async Task<IEnumerable<StockSplitData>> GetStockSplitDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return await DownloadYahooDataAsync<StockSplitData>(symbol, DataType.StockSplits, dataFrequency, startDate, endDate, includeAdjustedClose);
    }

    public static async Task<IEnumerable<CapitalGainData>> GetCapitalGainDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return await DownloadYahooDataAsync<CapitalGainData>(symbol, DataType.CapitalGains, dataFrequency, startDate, endDate, includeAdjustedClose);
    }

    private static async Task<IEnumerable<T>> DownloadYahooDataAsync<T>(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, BuildYahooUrl(symbol, dataType, dataFrequency, startDate, endDate, includeAdjustedClose));
            var response = await client.SendAsync(request);

            var result = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                // Handle success
                result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (!string.IsNullOrWhiteSpace(result))
                {
                    return dataType switch
                    {
                        DataType.HistoricalPrices => (IEnumerable<T>)ParseYahooData<HistoricalData>(result),
                        DataType.Dividends => (IEnumerable<T>)ParseYahooData<DividendData>(result),
                        DataType.CapitalGains => (IEnumerable<T>)ParseYahooData<CapitalGainData>(result),
                        DataType.StockSplits => (IEnumerable<T>)ParseYahooData<StockSplitData>(result),
                        _ => throw new ArgumentException("Invalid Enumerator Value", nameof(dataType))
                    };
                }
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.UnprocessableEntity)
                {
                    throw new InvalidOperationException($"'{symbol}' Symbol Not Available On Yahoo Finance");
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new InvalidOperationException("Yahoo Finance Authentication Error");
                }
                else
                {
                    throw new InvalidOperationException("Unspecified Error Occurred");
                }
            }
        }

        return Enumerable.Empty<T>();
    }

    private static IEnumerable<T> ParseYahooData<T>(string csvData) where T : class
    {
        var parsedDataList = new List<T>();
        var type = typeof(T);
        var rows = csvData.Split('\n');

        if (rows == null || rows.Length <= 1)
        {
            if (type == typeof(DividendData))
            {
                throw new InvalidOperationException("No Dividend Data Found");
            }
            else if (type == typeof(HistoricalData))
            {
                throw new InvalidOperationException("No Historical Data Found");
            }
            else if (type == typeof(CapitalGainData))
            {
                throw new InvalidOperationException("No Capital Gain Data Found");
            }
            else if (type == typeof(StockSplitData))
            {
                throw new InvalidOperationException("No Stock Split Data Found");
            }
            else
            {
                throw new InvalidOperationException("No Valid Data Found");
            }
        }

        // We are ignoring the first row which are headers
        for (var i = 1; i < rows?.Length; i++)
        {
            var row = rows[i];

            if (!string.IsNullOrWhiteSpace(row))
            {
                var column = row.Split(',');

                // Perform a try parse for all columns per row
                if (type == typeof(DividendData))
                {
                    var dateSuccess = DateTime.TryParse(column[0], CultureInfo.InvariantCulture, out var parsedDate);
                    var dividendSuccess = double.TryParse(column[1], CultureInfo.InvariantCulture, out var parsedDividend);

                    // Add either the parsed value or the default if there was a parsing error
                    DividendData dividendData = new()
                    {
                        Date = dateSuccess ? parsedDate : default,
                        Dividend = dividendSuccess ? parsedDividend : default
                    };

                    parsedDataList.Add((dividendData as T)!);
                }
                else if (type == typeof(HistoricalData))
                {
                    // Perform a try parse for all columns per row
                    var dateSuccess = DateTime.TryParse(column[0], CultureInfo.InvariantCulture, out var parsedDate);
                    var openSuccess = double.TryParse(column[1], CultureInfo.InvariantCulture, out var parsedOpen);
                    var highSuccess = double.TryParse(column[2], CultureInfo.InvariantCulture, out var parsedHigh);
                    var lowSuccess = double.TryParse(column[3], CultureInfo.InvariantCulture, out var parsedLow);
                    var closeSuccess = double.TryParse(column[4], CultureInfo.InvariantCulture, out var parsedClose);
                    var adjCloseSuccess = double.TryParse(column[5], CultureInfo.InvariantCulture, out var parsedAdjClose);
                    var volumeSuccess = double.TryParse(column[6], CultureInfo.InvariantCulture, out var parsedVolume);

                    // Add either the parsed value or the default if there was a parsing error
                    HistoricalData historicalData = new()
                    {
                        Date = dateSuccess ? parsedDate : default,
                        Open = openSuccess ? parsedOpen : default,
                        High = highSuccess ? parsedHigh : default,
                        Low = lowSuccess ? parsedLow : default,
                        Close = closeSuccess ? parsedClose : default,
                        AdjClose = adjCloseSuccess ? parsedAdjClose : default,
                        Volume = volumeSuccess ? parsedVolume : default
                    };
                    parsedDataList.Add((historicalData as T)!);
                }
                else if (type == typeof(CapitalGainData))
                {
                    // Perform a try parse for all columns per row
                    var dateSuccess = DateTime.TryParse(column[0], CultureInfo.InvariantCulture, out var parsedDate);
                    var capitalGainSuccess = double.TryParse(column[1], CultureInfo.InvariantCulture, out var parsedCapitalGain);

                    // Add either the parsed value or the default if there was a parsing error
                    CapitalGainData capitalGainData = new()
                    {
                        Date = dateSuccess ? parsedDate : default,
                        CapitalGain = capitalGainSuccess ? parsedCapitalGain : default
                    };
                    parsedDataList.Add((capitalGainData as T)!);
                }
                else if (type == typeof(StockSplitData))
                {
                    // Perform a try parse for all columns per row
                    var dateSuccess = DateTime.TryParse(column[0], CultureInfo.InvariantCulture, out var parsedDate);

                    // Add either the parsed value or the default if there was a parsing error
                    StockSplitData stockSplitData = new()
                    {
                        Date = dateSuccess ? parsedDate : default,
                        StockSplit = column[1]
                    };
                    parsedDataList.Add((stockSplitData as T)!);
                }
                else
                {
                    throw new ArgumentException("Data Type Not Supported");
                }
            }
        }

        return parsedDataList;
    }

    private static Uri BuildYahooUrl(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjClose = true) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v7/finance/download/{symbol}?period1={startDate.ToUnixTimestamp()}" +
            $"&period2={(endDate ?? DateTime.Now).ToUnixTimestamp()}&interval={GetIntervalString(dataFrequency)}&events={GetEventsString(dataType)}&includeAdjustedClose={includeAdjClose}"));

    private static string GetIntervalString(DataFrequency dataFrequency) =>
        dataFrequency switch
        {
            DataFrequency.Daily => "1d",
            DataFrequency.Weekly => "1wk",
            DataFrequency.Monthly => "1mo",
            _ => throw new ArgumentException("Invalid Enumerator Value", nameof(dataFrequency))
        };

    private static string GetEventsString(DataType dataType) =>
        dataType switch
        {
            DataType.HistoricalPrices => "history",
            DataType.Dividends => "div",
            DataType.StockSplits => "split",
            DataType.CapitalGains => "capitalGain",
            _ => throw new ArgumentException("Invalid Enumerator Value", nameof(dataType))
        };
}