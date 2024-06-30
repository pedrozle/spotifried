namespace Spotifried.Controllers;
using Microsoft.AspNetCore.Mvc;
using Spotifried.Models;

public class MusicController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AddMusic()
    {
        return View();
    }

}