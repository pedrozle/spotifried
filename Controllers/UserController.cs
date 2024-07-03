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
        var listUser = _userRepository.GetAllUser();
        return View(listUser);
    }

    [HttpPost]
    public IActionResult DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
        return RedirectToAction(nameof(Index));
    }


}