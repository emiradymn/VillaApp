using System;
using Microsoft.AspNetCore.Mvc;

namespace VillaVibe.Web.ViewComponents.AdminLayout;

public class _AdminScripts : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
