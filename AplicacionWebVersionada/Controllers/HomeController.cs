using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AplicacionWebVersionada.Models;

namespace AplicacionWebVersionada.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="logger">Este para...</param>
    /// 

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    /// <summary>
    /// Accion que se encar....
    /// </summary>
    /// <returns>View..</returns>

    public IActionResult Privacy()
    {
        return View();
    }
    /// <summary>
    /// Comentario de cambio
    /// </summary>
    /// <returns></returns>

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
