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
        ViewBag.Paquetes = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete(){
        ViewBag.Destinos = ORTWorld.ListaDestinos;
        ViewBag.Hoteles = ORTWorld.ListaHoteles;
        ViewBag.Aereos = ORTWorld.ListaAereos;
        ViewBag.Excursiones = ORTWorld.ListaExcursiones;
        return View();
    }
}
