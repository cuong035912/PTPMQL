using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
namespace DemoMvc.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string StudentID)
    {
        string strResult = "Hello" + FullName + " - " + StudentID;
        ViewBag.Student = strResult;
        return View();
    }
}
