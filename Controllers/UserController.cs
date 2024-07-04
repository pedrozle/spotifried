using Microsoft.AspNetCore.Mvc;
using Spotifried.Models;
using Spotifried.Repository.Interfaces;

namespace Spotifried.Controllers;

[ActionFilters]
public class UserController(IUserRepository userRepository) : Controller
{

    private readonly IUserRepository _userRepository = userRepository;

    public IActionResult Index()
    {

        var listMusic = new List<MusicModel>();
        var listAlbum = new List<AlbumModel>();
        var listArtist = new List<ArtistModel>();

        var list = new List<dynamic> { listMusic, listAlbum, listArtist };

        return View(list);
    }

    [HttpPost]
    public IActionResult DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
        return RedirectToAction(nameof(Index));
    }


}