using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Spotifried.Models;

namespace Spotifried.Controllers;

[ActionFilters]
public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}
