namespace Spotifried.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Spotifried.Models;
using Spotifried.Models.ViewModels;
using Spotifried.Repository.Interfaces;
using Spotifried.Services;

[ActionFilters]
public class MusicController(IMusicRepository musicRepository, SpotifyService spotifyService) : Controller
{

    private readonly IMusicRepository _musicRepository = musicRepository;
    private readonly SpotifyService _spotifyService = spotifyService;

    public IActionResult Album()
    {
        return View();
    }

    public IActionResult Search()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SearchParam()
    {
        string termoPesquisa = Request.Form["searchInput"]!;

        var response = _spotifyService.Search(termoPesquisa, "artist");

        var json = JsonConvert.DeserializeObject<RootModel>(await response);
        Console.WriteLine(json);
        return View("Search", json);
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