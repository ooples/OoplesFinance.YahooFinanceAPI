using System.Net.Http;

namespace OoplesFinance.YahooFinanceAPI.Helpers
{
    internal sealed class CrumbHelper
    {
        /// <summary>
        ///  Crumb value for the Yahoo Finance API
        /// </summary>
        internal readonly string Crumb;
                
        private static List<string> cookies = new List<string>();
        private static CrumbHelper? _instance;
        CrumbHelper()
        {
            Crumb = string.Empty;

            HttpClient client = GetHttpClient();
            
            var loginResponse = client.GetAsync("https://login.yahoo.com/").Result;            

            if (loginResponse.IsSuccessStatusCode)
            {
                var login = loginResponse.Content.ReadAsStringAsync().Result;
                if (loginResponse.Headers.TryGetValues(name: "Set-Cookie", out IEnumerable<string>? setCookie))
                {
                    cookies = setCookie.Where(c => c.ToLower().IndexOf("domain=.yahoo.com") != -1).ToList();                    
                    var crumbResponse = client.GetAsync("https://query1.finance.yahoo.com/v1/test/getcrumb").Result;

                    if (crumbResponse.IsSuccessStatusCode)
                    {
                        Crumb = crumbResponse.Content.ReadAsStringAsync().Result;
                    }
                }
            }
            if (string.IsNullOrEmpty(Crumb))
            {
                throw new Exception("Failed to get crumb");
            }
        }

        public HttpClient GetHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient client = new HttpClient(handler);            
            client.DefaultRequestHeaders.Add("Cookie", cookies);
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
            client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            client.DefaultRequestHeaders.Add("Pragma", "no-cache");
            client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
            return client;
        }

        /// <summary>
        /// Single instance of the CrumbHelper
        /// </summary>        
        public static CrumbHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CrumbHelper();
                }
                return _instance;
            }
        }
    }
}
