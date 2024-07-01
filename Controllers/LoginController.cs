using Microsoft.AspNetCore.Mvc;
using Spotifried.Models;
using Spotifried.Repository.Interfaces;

namespace Spotifried.Controllers;

public class LoginController(IUserRepository userRepository) : Controller
{

    private readonly IUserRepository _userRepository = userRepository;

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(UserLoginModel user)
    {

        Dictionary<string, string> dict;
        string message = "";

        if (!ModelState.IsValid)
        {
            dict = new Dictionary<string, string>
            {
                { "Type", "warning" },
                { "Message", "Dados inválidos"}
            };
            TempData["Alert"] = dict;
            return View("Index");
        }


        var userDB = _userRepository.GetByUsername(user.Username);

        if (userDB != null)
        {
            if (userDB.CheckPassword(user.Password))
                return RedirectToAction("Index", "Home");
            else 
                message = "Senha incorreta!";
        }
        else
            message = "Usuário não encontrado!";

        dict = new Dictionary<string, string>
            {
                { "Type", "danger" },
                { "Message", message }
            };
        TempData["Alert"] = dict;
        return View("Index");


    }

}