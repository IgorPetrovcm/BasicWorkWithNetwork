namespace Program;
using System.Net;
using System.Net.Http.Headers;

class Program 
{
    static HttpClient client = new HttpClient();
    static async Task Main()
    {   
        System.Console.WriteLine("Input page name: ");
        Uri uri = new UriBuilder("https://",Console.ReadLine()).Uri;
        using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri))
        {
            try 
            {
                HttpResponseMessage response = await client.SendAsync(request);
                System.Console.WriteLine("status: " + response.ReasonPhrase);
                if (response.ReasonPhrase != "OK") return;

                foreach (var header in response.Headers)
                {
                    System.Console.WriteLine(header.Key + ": ");
                    foreach (var value in header.Value)
                    {
                        System.Console.WriteLine(value);
                    }
                }
                System.Console.WriteLine((await response.Content.ReadAsStringAsync()).Substring(0,1000));
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}