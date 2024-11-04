using System;
using Microsoft.AspNetCore.Mvc;

namespace VillaVibe.Web.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
