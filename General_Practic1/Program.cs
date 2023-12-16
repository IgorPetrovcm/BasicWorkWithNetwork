namespace Program;
using System.Net;
using System.Net.Http.Headers;

class Program 
{
    static HttpClient client = new HttpClient();
    static async Task Main()
    {
        System.Console.WriteLine("Input name site");
        UriBuilder build = new UriBuilder();
        build.Host = Console.ReadLine();
        build.Scheme = "https";

        Uri uri = build.Uri;

        using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri.OriginalString))
        {
            try 
            {
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.ReasonPhrase != "OK")  
                {
                    System.Console.WriteLine("error status code: " + response.ReasonPhrase);

                }
                System.Console.WriteLine("name status code: " + response.ReasonPhrase);
                HttpHeaders headers = response.Headers;
                foreach (KeyValuePair<string,IEnumerable<string>> pair in headers)
                {
                    System.Console.WriteLine(pair.Key + ":\t");
                    foreach (string value in pair.Value) 
                    {
                        System.Console.WriteLine(value);
                    }
                }
                System.Console.WriteLine("\nContent:");
                HttpContent content = response.Content;
                string contentText = await content.ReadAsStringAsync();
                System.Console.WriteLine(contentText.Substring(0, 2000));
            }
            catch (Exception e) 
            {
                System.Console.WriteLine(e.Message);
            }
        }
        

    }
}