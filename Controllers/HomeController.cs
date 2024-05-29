using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4___Klawir___Cywiner.Models;

namespace TP4___Klawir___Cywiner.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ORTWorld = ORTWorld.Paquetes;
        return View();
    }
}
