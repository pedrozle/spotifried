using Microsoft.AspNetCore.Mvc;
using Spotifried.Models.ViewModels;

namespace Spotifried.ViewComponents;

public class Footer : ViewComponent
{

    public async Task<IViewComponentResult> InvokeAsync(AudioModel? audio)
    {
        return View(audio);
    }

}