using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolionToDo.Models;

namespace HolionToDo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //My index method, that controls the interaction with my index page
    public IActionResult Index()
    {
        return View();
    }
}
