namespace Program
{
    using System.Reflection.Metadata;
    using HtmlAgilityPack;
    using System.Net.Http;
    

    class Program
    {
        private static HttpClient client = new HttpClient();
        static void Main()
        {
            /*HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://github.com"));
            HttpResponseMessage resp = client.SendAsync(request).Result;
            Console.WriteLine(resp.Content.ReadAsStringAsync().Result);*/
            
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html: GetHtmlDocument(url: new Uri("https://google.com")).ToString());
            HtmlNode htmlBody = doc.DocumentNode.SelectSingleNode("//body");
            Console.WriteLine(htmlBody.OuterHtml);
        }

        static async Task<string> GetHtmlDocument(Uri url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                HttpResponseMessage resp = client.SendAsync(request).Result;
                return resp.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.Message);
            }

            throw new Exception();
        }
        
    }
}