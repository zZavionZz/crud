using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers;
    public class Home : Controller
    {
        IActionResult Index()
        {
            return View();
        }
        IActionResult Crude()
        {
            return View();
        }

    }