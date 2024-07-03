using Microsoft.AspNetCore.Mvc;
using Spotifried.Models;

namespace Spotifried.ViewComponents;

public class NotificationPopUp : ViewComponent
{

    public IViewComponentResult? Invoke(NotificationModel model)
    {
        return View(model);
    }

}