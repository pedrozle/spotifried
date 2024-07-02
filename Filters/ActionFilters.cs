using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Spotifried.Models;

namespace Spotifried;

public class ActionFilters : ActionFilterAttribute
{

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        string? session = context.HttpContext.Session.GetString(Globals.KEY);

        if (session.IsNullOrEmpty())
        {
            context.Result = new RedirectToRouteResult(new RouteValueDictionary{
                {"controller", "Login"},
                {"action", "Index"}
            });
        }
        else
        {
            UserModel? user = JsonConvert.DeserializeObject<UserModel>(session!);
            if (user is null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary{
                {"controller", "Login"},
                {"action", "Index"}
            });
            }
        }

        base.OnActionExecuting(context);
    }

}