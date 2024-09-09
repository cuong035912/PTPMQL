using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
namespace DemoMvc.Controllers;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Hello" + ps.FullName + " - " + ps.PersonID;
        ViewBag.Person = strResult;
        return View();
    }
}
