using Microsoft.AspNetCore.Mvc;
using Spotifried.Helpers.Interfaces;
using Spotifried.Models;
using Spotifried.Repository.Interfaces;

namespace Spotifried.Controllers;

public class LoginController(IUserRepository userRepository, ISessao sessao) : Controller
{

    private readonly IUserRepository _userRepository = userRepository;

    private readonly ISessao _sessao = sessao;

    public IActionResult Index()
    {
        if (_sessao.GetSession() != null)
            return RedirectToAction("Index", "Home");
        return View();
    }

    public IActionResult Login(){
        return View();
    }

    public IActionResult Privacy()
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


        var userDB = _userRepository.GetByUsername(user.Username!);

        if (userDB != null)
        {
            if (userDB.CheckPassword(user.Password!))
            {
                _sessao.SetSession(userDB);
                return RedirectToAction("Index", "Home");
            }
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

    public IActionResult Logout()
    {
        _sessao.DeleteSession();
        return RedirectToAction("Index", "Login");
    }

}