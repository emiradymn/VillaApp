using System;
using Microsoft.AspNetCore.Mvc;

namespace VillaVibe.Web.ViewComponents.Default_Index;

public class _DefaultMessage : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }

}
