using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace HttpPostRequest;
using HtmlAgilityPack;
using System.Net.Http;


class Program
{
    private static HttpClient client = new HttpClient();
    static async Task Main()
    {
        Dictionary<string, string> _params = new Dictionary<string, string>()
        {
            { "id", "6" }
        };

        FormUrlEncodedContent content = new FormUrlEncodedContent(_params);

        HttpResponseMessage body = await client.PostAsync("http://localhost:5068", content);

        Console.WriteLine(await body.Content.ReadAsStringAsync());
    }
}