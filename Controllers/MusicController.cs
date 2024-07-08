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
        // string searchInput = Request.Form["searchInput"]!;
        // string searchType = Request.Form["searchType"]!;
        string searchType = "Tudo";

        // searchType = searchType switch
        // {
        //     "Artista" => "artist",
        //     "Album" => "album",
        //     "Musica" => "track",
        //     _ => "artist,album,track",
        // };
        // var json = await _spotifyService.Search(searchInput, searchType);

        // Write the string array to a new file named "WriteLines.txt".
        // using (StreamWriter outputFile = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "WriteLines.json")))
        // {
        //     outputFile.WriteLine(json);
        // }

        var json =  await System.IO.File.ReadAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), "WriteLines.json"));

        dynamic obj = searchType switch
        {
            "Artista" => JsonConvert.DeserializeObject<RootModelArtist>(json)!,
            "Album" => JsonConvert.DeserializeObject<RootModelAlbum>(json)!,
            "Musica" => JsonConvert.DeserializeObject<RootModelMusic>(json)!,
            _ => JsonConvert.DeserializeObject<RootModelAll>(json)!
        };

        return View("Search", obj);
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