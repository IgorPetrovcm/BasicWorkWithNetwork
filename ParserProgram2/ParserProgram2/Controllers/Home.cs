
using Microsoft.AspNetCore.Mvc;
namespace MvcApp;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string address)
    {
        using (HttpClient client = new HttpClient())
        {
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, address))
            {
                try
                {
                    using (HttpResponseMessage resp = client.SendAsync(request).Result)
                    {
                        ViewBag.Message = resp.Content.ReadAsStringAsync().Result;
                        return View();
                    }
                }
                catch
                {
                    return View("/Views/StatusCodes/AddressNotFound.cshtml");
                }
            }
        }
    }
}