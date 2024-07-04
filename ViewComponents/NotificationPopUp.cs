using Microsoft.AspNetCore.Mvc;
using Spotifried.Models;
using Spotifried.Models.ViewModels;

namespace Spotifried.ViewComponents;

public class NotificationPopUp : ViewComponent
{

    public IViewComponentResult? Invoke(NotificationModel model)
    {
        return View(model);
    }

}