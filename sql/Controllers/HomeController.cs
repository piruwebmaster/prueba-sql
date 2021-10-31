using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sql.Models;

namespace sql.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private EmployeeDbContext dbcontext;

    public HomeController(ILogger<HomeController> logger, EmployeeDbContext dbcontext)
    {
        this.dbcontext = dbcontext;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var persona = dbcontext.Personas.First();

        ViewData["persona"] = persona;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
