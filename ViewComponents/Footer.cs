using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Spotifried.Models;

namespace Spotifried.ViewComponents;

public class Footer : ViewComponent
{

    public async Task<IViewComponentResult> InvokeAsync()
    {
        string? session = HttpContext.Session.GetString(Globals.KEY);

        if (session.IsNullOrEmpty()) return View(null);

        UserModel? user = JsonConvert.DeserializeObject<UserModel>(session!);

        return View(user);
    }

}