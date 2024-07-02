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

    public IActionResult AddUser()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult AddUser(UserModel User)
    {
        if (!ModelState.IsValid) return View(User);
        User.CreationDate = DateTime.Now;
        _userRepository.AddUser(User);
        return RedirectToAction(nameof(Index));
    }

}