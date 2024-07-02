using Spotifried.Models;
using Newtonsoft.Json;
using Spotifried.Helpers.Interfaces;

namespace Spotifried.Helpers;

public class Session(IHttpContextAccessor httpContext) : ISessao
{
    private readonly IHttpContextAccessor _httpContext = httpContext;
    public UserModel? GetSession()
    {
        string sessaoUsuario = _httpContext.HttpContext.Session.GetString(Globals.KEY);

        if (string.IsNullOrEmpty(sessaoUsuario)) return null;

        return JsonConvert.DeserializeObject<UserModel>(sessaoUsuario);
    }

    public void SetSession(UserModel usuario)
    {
        string valor = JsonConvert.SerializeObject(usuario);

        _httpContext.HttpContext.Session.SetString(Globals.KEY, valor);
    }

    public void DeleteSession()
    {
        _httpContext.HttpContext.Session.Remove(Globals.KEY);
    }
}
