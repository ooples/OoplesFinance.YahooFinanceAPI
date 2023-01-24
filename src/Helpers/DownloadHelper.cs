using System.Text;

namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal static class DownloadHelper
{
    /// <summary>
    /// Downloads the raw csv data using the chosen parameters
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="dataType"></param>
    /// <param name="dataFrequency"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="includeAdjustedClose"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    internal static async Task<IEnumerable<string[]>> DownloadRawCsvDataAsync(string symbol, DataType dataType, DataFrequency dataFrequency,
        DateTime startDate, DateTime? endDate, bool includeAdjustedClose)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            var rawData = await DownloadRawDataAsync(BuildYahooCsvUrl(symbol, dataType, dataFrequency, startDate, endDate, includeAdjustedClose));

            if (!string.IsNullOrWhiteSpace(rawData))
            {
                return GetBaseCsvData(rawData);
            }
        }

        return Enumerable.Empty<string[]>();
    }

    /// <summary>
    /// Downloads the trending json data using the chosen parameters
    /// </summary>
    /// <param name="country"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    internal static async Task<string> DownloadTrendingDataAsync(Country country, int count)
    {
        if (count <= 0)
        {
            throw new ArgumentException("Count Must Be At Least 1 To Return Any Data");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooTrendingUrl(country, count));
        }
    }

    /// <summary>
    /// Base method to download any raw yahoo data
    /// </summary>
    /// <param name="uriString"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="ArgumentException"></exception>
    private static async Task<string> DownloadRawDataAsync(string urlString)
    {
        // max length for a uri
        if (urlString.Length > 2083)
        {
            throw new ArgumentException("You Have Included Too Many Symbols");
        }
        else
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, urlString);
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                // Handle success
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                // Handle failure
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new InvalidOperationException("Requested Information Not Available On Yahoo Finance");
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
    }

    /// <summary>
    /// Downloads the recommended json data using the chosen symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadRecommendDataAsync(string symbol)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooRecommendUrl(symbol));
        }
    }

    /// <summary>
    /// Downloads the insights json data using the chosen symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadInsightsDataAsync(string symbol)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooInsightsUrl(symbol));
        }
    }

    /// <summary>
    /// Downloads the chart json data using the chosen symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="timeRange"></param>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadChartDataAsync(string symbol, TimeRange timeRange, TimeInterval timeInterval)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooChartUrl(symbol, timeRange, timeInterval));
        }
    }

    /// <summary>
    /// Downloads the spark chart json data using the chosen symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="timeRange"></param>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadSparkChartDataAsync(string symbol, TimeRange timeRange, TimeInterval timeInterval)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooSparkChartUrl(new string[] { symbol }, timeRange, timeInterval));
        }
    }

    /// <summary>
    /// Downloads the spark chart json data using the chosen symbols
    /// </summary>
    /// <param name="symbols"></param>
    /// <param name="timeRange"></param>
    /// <param name="timeInterval"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadSparkChartDataAsync(IEnumerable<string> symbols, TimeRange timeRange, TimeInterval timeInterval)
    {
        if (!symbols.Any())
        {
            throw new ArgumentException("Symbols Parameter Must Contain At Least One Symbol");
        }
        else if (symbols.Count() > 250)
        {
            throw new ArgumentException("Symbols Parameter Can't Have More Than 250 Symbols");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooSparkChartUrl(symbols, timeRange, timeInterval));
        }
    }

    /// <summary>
    /// Downloads the stats json data using the chosen symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="country"></param>
    /// <param name="language"></param>
    /// <param name="module"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadStatsDataAsync(string symbol, Country country, Language language, YahooModule module)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooStatsUrl(symbol, country, language, module));
        }
    }

    /// <summary>
    /// Downloads the real-time quote json data using the chosen symbol
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="country"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadRealTimeQuoteDataAsync(string symbol, Country country, Language language)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol Parameter Can't Be Empty Or Null");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooRealTimeQuoteUrl(new string[] { symbol }, country, language));
        }
    }

    /// <summary>
    /// Downloads the real-time quote json data using the chosen symbols
    /// </summary>
    /// <param name="symbols"></param>
    /// <param name="country"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static async Task<string> DownloadRealTimeQuoteDataAsync(IEnumerable<string> symbols, Country country, Language language)
    {
        if (!symbols.Any())
        {
            throw new ArgumentException("Symbols Parameter Must Contain At Least One Symbol");
        }
        else if (symbols.Count() > 250)
        {
            throw new ArgumentException("Symbols Parameter Can't Have More Than 250 Symbols");
        }
        else
        {
            return await DownloadRawDataAsync(BuildYahooRealTimeQuoteUrl(symbols, country, language));
        }
    }

    /// <summary>
    /// Gets the base csv data that is used by all csv helper classes
    /// </summary>
    /// <param name="csvData"></param>
    /// <returns></returns>
    internal static IEnumerable<string[]> GetBaseCsvData(string? csvData)
    {
        IEnumerable<string[]> result = Enumerable.Empty<string[]>();
        var rows = csvData?.Split('\n');

        if (rows != null && rows.Length > 1)
        {
            // We are ignoring the first row which are headers
            result = rows.Skip(1).Select(x => x.Split(','));
        }

        return result;
    }
}