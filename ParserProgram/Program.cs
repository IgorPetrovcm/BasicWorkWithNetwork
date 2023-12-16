namespace Program 
{
    using System.Net;
    using System.Net.Http;
    using System.Net.Mime;

    class Program 
    {
        static HttpClient client = new HttpClient();
        static async Task Main()
        {
            Uri uri = new Uri("https://github.com/");
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri.OriginalString))
            {
                using (HttpResponseMessage resp = client.SendAsync(request).Result)
                {
                    using (StreamWriter writer = new StreamWriter("htmlpage.txt"))
                    {
                        string htmlpage = await resp.Content.ReadAsStringAsync();
                        writer.Write(htmlpage);
                    }
                }
            }            

            using (StreamReader reader = new StreamReader("htmlpage.txt"))
            {
                string line;
                while (reader.ReadLine() != null)
                {
                    line = reader.ReadLine();
                    if (line.Contains(@"<div class=""position-relative pt-3 pt-sm-8 pt-lg-12 container-xl js-build-in-trigger build-in-animate"" data-hpc="">")) 
                    System.Console.WriteLine(true);
                }
            }
        }
    }
}