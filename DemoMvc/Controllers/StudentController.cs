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
}
