using System.Diagnostics;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost] 
    public IActionResult Demo(string FullName)
    {
        string strResult = "Xin chào " + FullName;
        ViewBag.Demo = strResult;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
