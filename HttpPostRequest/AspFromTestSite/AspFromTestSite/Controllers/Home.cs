namespace MvcApp;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(int id)
    {
        ViewData["Message"] = id;
        return View();
    }
}