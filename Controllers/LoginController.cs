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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(UserLoginModel user)
    {

        Dictionary<string, string> dict;
        string content = "";

        if (!ModelState.IsValid)
        {
            dict = new Dictionary<string, string>
            {
                { "Title", "Dados Inválidos" },
                { "Content", "Insira as informações de login"},
                {"Type", "warning"},
                {"Icon", "fa-exclamation"}
            };
            TempData["Alert"] = dict;
            return View("Login");
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
                content = "Senha incorreta!";
        }
        else
            content = "Usuário não encontrado!";

        dict = new Dictionary<string, string>
            {
                { "Title", "Dados Inválidos" },
                { "Content", content},
                {"Type", "danger"},
                {"Icon", "fa-times"}
            };
        TempData["Alert"] = dict;
        TempData["Alert"] = dict;
        return View("Login");


    }

    [HttpPost]
    public IActionResult Register(UserModel user)
    {

        Dictionary<string, string> dict;
        string content = "";

        if (!ModelState.IsValid)
        {
            dict = new Dictionary<string, string>
            {
                { "Title", "Dados Inválidos" },
                { "Content", "Insira as informações de login"},
                {"Type", "warning"},
                {"Icon", "fa-exclamation"}
            };
            TempData["Alert"] = dict;
            return View("Register");
        }

        if (_userRepository.GetByEmail(user.Email) != null)
        {
            dict = new Dictionary<string, string>
            {
                { "Title", "Usuário já existe" },
                { "Content", "O email informado já está cadastrado"},
                {"Type", "danger"},
                {"Icon", "fa-exclamation"}
            };
            TempData["Alert"] = dict;
            return View("Register");
        }


        if (_userRepository.GetByUsername(user.Username) != null)
        {
            dict = new Dictionary<string, string>
            {
                { "Title", "Usuário já existe" },
                { "Content", "O usuário informado já está cadastrado"},
                {"Type", "danger"},
                {"Icon", "fa-exclamation"}
            };
            TempData["Alert"] = dict;
            return View("Register");
        }
        var pass = user.Password;
        user.CreationDate = DateTime.Now;
        user.SetPasswordHash();
        var userDB = _userRepository.AddUser(user);

        if (userDB.CheckPassword(pass))
        {
            _sessao.SetSession(userDB);
            return RedirectToAction("Index", "Home");
        }
        return View("Register");
    }


    public IActionResult Logout()
    {
        _sessao.DeleteSession();
        return RedirectToAction("Index", "Login");
    }

}