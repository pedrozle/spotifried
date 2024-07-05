namespace Spotifried.Controllers;
using Microsoft.AspNetCore.Mvc;
using Spotifried.Models;
using Spotifried.Repository.Interfaces;

[ActionFilters]
public class MusicController(IMusicRepository musicRepository) : Controller
{

    private readonly IMusicRepository _musicRepository = musicRepository;

    public IActionResult Album()
    {
        return View();
    }

    public IActionResult AddMusic()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DeleteMusic(int id)
    {
        _musicRepository.DeleteMusic(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult AddMusic(MusicModel music)
    {
        if (!ModelState.IsValid) return View(music);
        _musicRepository.AddMusic(music);
        return RedirectToAction(nameof(Index));
    }

}