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

    public IActionResult GuardarPaquete(int Destinos, int Aereos, int Hoteles, int Excursiones, List<string> ListaDestinos, List<string> ListaAereos, List<string> ListaHoteles, List<string> ListaExcursiones){
        if(Destinos >= 0 && Destinos <= 10 && Aereos >= 0 && Aereos <= 10 && Hoteles >= 0 && Hoteles <= 10 && Excursiones >= 0 && Excursiones <= 10)
        {
            string DestinoGuardar = ListaDestinos[Destinos];
            string AereoGuardar = ListaAereos[Aereos];
            string HotelGuardar = ListaHoteles[Hoteles];
            string ExcursionesGuardar = ListaExcursiones[Excursiones];
            Paquete PaqueteNuevo = new Paquete(AereoGuardar, HotelGuardar, ExcursionesGuardar);
            ORTWorld.IngresarPaquete(DestinoGuardar, PaqueteNuevo);
            return View();
        }
        else{
            ViewBag.Error = "Error";
            return View();
        }
    }
}
