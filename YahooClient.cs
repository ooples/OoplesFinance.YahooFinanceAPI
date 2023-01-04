namespace OoplesFinance.YahooFinanceAPI;

public static class YahooClient
{
    public static async Task<IEnumerable<TickerData>> GetHistoricalDataAsync(string symbol, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        return await DownloadYahooDataAsync(symbol, DataType.HistoricalPrices, dataFrequency, startDate, endDate, includeAdjustedClose).ConfigureAwait(false);
    }

    public static async Task<IEnumerable<TickerData>> DownloadYahooDataAsync(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjustedClose = true)
    {
        using var client = new HttpClient();
        using var request = new HttpRequestMessage(HttpMethod.Get, BuildYahooUrl(symbol, dataType, dataFrequency, startDate, endDate, includeAdjustedClose));
        var response = await client.SendAsync(request).ConfigureAwait(false);

        var result = string.Empty;
        if (response.IsSuccessStatusCode)
        {
            // Handle success
            result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!string.IsNullOrWhiteSpace(result))
            {
                return await ParseDataAsync(result).ConfigureAwait(false);
            }
        }

        return Enumerable.Empty<TickerData>();
    }

    public static async Task<IEnumerable<TickerData>> ParseDataAsync(string csvData)
    {
        using var csvReader = new CsvReader(new StringReader(csvData), CultureInfo.InvariantCulture);
        return await csvReader.GetRecordsAsync<TickerData>().ToListAsync();
    }

    public static Uri BuildYahooUrl(string symbol, DataType dataType, DataFrequency dataFrequency, DateTime startDate, DateTime? endDate = null, bool includeAdjClose = true) =>
        new(string.Format(CultureInfo.InvariantCulture, $"https://query1.finance.yahoo.com/v7/finance/download/{symbol}?period1={startDate.ToUnixTimestamp()}" +
            $"&period2={(endDate ?? DateTime.Now).ToUnixTimestamp()}&interval={GetIntervalString(dataFrequency)}&events={GetEventsString(dataType)}&includeAdjustedClose={includeAdjClose}"));

    public static string GetIntervalString(DataFrequency dataFrequency) =>
        dataFrequency switch
        {
            DataFrequency.Daily   => "1d",
            DataFrequency.Weekly  => "1wk",
            DataFrequency.Monthly => "1mo",
            _                     => throw new ArgumentException("Invalid Enumerator Value", nameof(dataFrequency))
        };

    public static string GetEventsString(DataType dataType) =>
        dataType switch
        {
            DataType.HistoricalPrices => "history",
            DataType.Dividends        => "div",
            DataType.StockSplits      => "split",
            DataType.CapitalGains     => "capitalGain",
            _                         => throw new ArgumentException("Invalid Enumerator Value", nameof(dataType))
        };
}