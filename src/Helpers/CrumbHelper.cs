using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OoplesFinance.YahooFinanceAPI.Tests.Unit")]
namespace OoplesFinance.YahooFinanceAPI.Helpers
{
    internal sealed class CrumbHelper
    {
        /// <summary>
        ///  Crumb value for the Yahoo Finance API
        /// </summary>
        internal string Crumb { get; private set; }
        internal static HttpMessageHandler? handler;
        private List<string> cookies = [];
        private static CrumbHelper? _instance;

        CrumbHelper()
        {
            handler = new HttpClientHandler();
            Crumb = string.Empty;
        }

        internal void Destroy()
        {
            _instance = null;
        }

        public async Task SetCrumbAsync()
        {
            var client = GetHttpClient();
            var loginResponse = await client.GetAsync("https://login.yahoo.com/");            

            if (loginResponse.IsSuccessStatusCode)
            {
                var login = await loginResponse.Content.ReadAsStringAsync();
                if (loginResponse.Headers.TryGetValues(name: "Set-Cookie", out IEnumerable<string>? setCookie))
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

        public static HttpClient GetHttpClient()
        {
            HttpClient client = new(handler ?? new HttpClientHandler());     
            client.DefaultRequestHeaders.Add("Cookie", Instance.cookies);
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
            client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            client.DefaultRequestHeaders.Add("Pragma", "no-cache");
            client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

            return client;
        }

        /// <summary>
        /// Gets CrumbHelper instance, and gets crumb if not already set
        /// </summary>
        /// <param name="setCrumb">Set to false for not setting the crumb.</param>
        /// <returns></returns>
        public static async Task<CrumbHelper> GetInstance(bool setCrumb = true)
        {
            if (string.IsNullOrEmpty(Instance.Crumb) && setCrumb)
            {
                await Instance.SetCrumbAsync();
            }

            return Instance;
        }

        /// <summary>
        /// Single instance of the CrumbHelper
        /// </summary>        
        private static CrumbHelper Instance
        {
            get
            {
                return _instance ??= new CrumbHelper();
            }
        }
    }
}