using System;
using Microsoft.AspNetCore.Mvc;

namespace Tennis.Web.Controllers
{
    public class HomeController : Controller
    {
        const string PageTitle = "First page";

        public IActionResult Index()
        {
            ViewData["Title"] = PageTitle;
            return View();
        }
    }
}