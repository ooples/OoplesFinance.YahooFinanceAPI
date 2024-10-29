// CrumbHelper.cs

#region using

using System.Runtime.CompilerServices;

#endregion

[assembly: InternalsVisibleTo("OoplesFinance.YahooFinanceAPI.Tests.Unit")]

namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal sealed class CrumbHelper
{
    #region Fields

    private static CrumbHelper? _instance;

    internal static HttpMessageHandler? handler;
    private List<string> cookies = [];

    #endregion

    private CrumbHelper()
    {
        handler = GetClientHandler(); 
        Crumb = string.Empty;
    }

    #region Properties

    /// <summary>
    ///     Crumb value for the Yahoo Finance API
    /// </summary>
    internal string Crumb { get; private set; }

    /// <summary>
    ///     Single instance of the CrumbHelper
    /// </summary>
    private static CrumbHelper Instance
    {
        get { return _instance ??= new CrumbHelper(); }
    }

    #endregion

    #region Static Methods

    public static HttpClient GetHttpClient()
    {
        HttpClient client = new(handler ?? GetClientHandler());
        client.DefaultRequestHeaders.Add("Cookie", Instance.cookies);
        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
        client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
        client.DefaultRequestHeaders.Add("Connection", "keep-alive");
        client.DefaultRequestHeaders.Add("Pragma", "no-cache");
        client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

        return client;
    }

    public static async Task<CrumbHelper> GetInstance()
    {
        if (string.IsNullOrEmpty(Instance.Crumb))
        {
            await Instance.SetCrumbAsync();
        }

        return Instance;
    }

    private static HttpClientHandler GetClientHandler()
    {
        return YahooClient.IsThrottled
            ? new DownloadThrottleQueueHandler(40, TimeSpan.FromMinutes(1)) //40 calls in a minute
            : new HttpClientHandler();
    }

    #endregion

    #region Public Methods

    public async Task SetCrumbAsync()
    {
        var client = GetHttpClient();
        var loginResponse = await client.GetAsync("https://login.yahoo.com/");

        if (loginResponse.IsSuccessStatusCode)
        {
            var login = await loginResponse.Content.ReadAsStringAsync();
            if (loginResponse.Headers.TryGetValues("Set-Cookie", out var setCookie))
            {
                cookies = new List<string>(setCookie.Where(c => c.ToLower().IndexOf("domain=.yahoo.com") > 0));
                var crumbResponse = await client.GetAsync("https://query1.finance.yahoo.com/v1/test/getcrumb");

                if (crumbResponse.IsSuccessStatusCode)
                {
                    Crumb = await crumbResponse.Content.ReadAsStringAsync();
                }
            }
        }

        if (string.IsNullOrEmpty(Crumb))
        {
            throw new Exception("Failed to get crumb");
        }
    }

    #endregion

    #region Internal Methods

    internal void Destroy()
    {
        _instance = null;
    }

    #endregion
}

internal class DownloadThrottleQueueHandler : HttpClientHandler
{
    #region Fields

    private readonly ThrottleService _throttle;

    #endregion

    public DownloadThrottleQueueHandler(int maxActions, TimeSpan maxPeriod)
    {
        _throttle = new ThrottleService(maxActions, maxPeriod);
    }

    #region Override Methods

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        return await _throttle.QueueAsync(async () => await base.SendAsync(request, cancellationToken), cancellationToken);
    }

    #endregion

    #region Nested type: ThrottleService

    private class ThrottleService
    {
        #region Fields

        private readonly TimeSpan _maxPeriod;
        private readonly SemaphoreSlim _throttleActions, _throttlePeriods;

        #endregion

        public ThrottleService(int maxActions, TimeSpan maxPeriod)
        {
            _throttleActions = new SemaphoreSlim(maxActions, maxActions);
            _throttlePeriods = new SemaphoreSlim(maxActions, maxActions);
            _maxPeriod = maxPeriod;
        }

        #region Public Methods

        public async Task<T> QueueAsync<T>(Func<Task<T>> action, CancellationToken cancel)
        {
            await _throttleActions.WaitAsync(cancel);

            try
            {
                await _throttlePeriods.WaitAsync(cancel);

                // Release after period [Note: Intentionally not awaited]
                // - Allow bursts up to maxActions requests at once
                // - Do not allow more than maxActions requests per period
                _ = Task.Delay(_maxPeriod).ContinueWith(tt => { _throttlePeriods.Release(1); }, cancel);

                return await action();
            }
            finally
            {
                _throttleActions.Release();
            }
        }

        #endregion
    }

    #endregion
}