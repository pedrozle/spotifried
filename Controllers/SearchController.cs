namespace Spotifried.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Spotifried.Models;
using Spotifried.Models.ViewModels;
using Spotifried.Repository.Interfaces;
using Spotifried.Services;

[ActionFilters]
public class SearchController(SpotifyService spotifyService) : Controller
{
    private readonly SpotifyService _spotifyService = spotifyService;

    [HttpGet]
    public IActionResult Index()
    {
        // Carrega a view sem dados de formulário
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(dynamic _)
    {
        string searchInput = Request.Form["searchInput"]!;
        string searchType = Request.Form["searchType"]!;

        searchType = searchType switch
        {
            "Artista" => "artist",
            "Album" => "album",
            "Musica" => "track",
            _ => "artist,album,track",
        };
        var json = await _spotifyService.Search(searchInput, searchType);

        dynamic obj;

        List<Tuple<string, dynamic>> model = [
            new Tuple<string, dynamic>("_", searchInput)
        ];

        switch (searchType)
        {
            case "artist":
                obj = JsonConvert.DeserializeObject<RootModelArtist>(json)!;
                model.Add(new Tuple<string, dynamic>("Artistas", obj.artists));
                break;
            case "album":
                obj = JsonConvert.DeserializeObject<RootModelAlbum>(json)!;
                model.Add(new Tuple<string, dynamic>("Álbuns", obj.albums));
                break;
            case "track":
                obj = JsonConvert.DeserializeObject<RootModelMusic>(json)!;
                model.Add(new Tuple<string, dynamic>("Músicas", obj.tracks));
                break;
            default:
                obj = JsonConvert.DeserializeObject<RootModelAll>(json)!;
                model.Add(new Tuple<string, dynamic>("Músicas", obj.tracks));
                model.Add(new Tuple<string, dynamic>("Álbuns", obj.albums));
                model.Add(new Tuple<string, dynamic>("Artistas", obj.artists));
                break;
        }


        return View("Index", model);
    }


}