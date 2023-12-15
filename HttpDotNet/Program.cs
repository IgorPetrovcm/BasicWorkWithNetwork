namespace Program;
using System.Net.Http;
class Program 
{
    static async Task Main()
    {
        HttpClient http = new HttpClient();
        var result = http.GetAsync("https://github.com/");
        System.Console.WriteLine(result.Result);
    }
}