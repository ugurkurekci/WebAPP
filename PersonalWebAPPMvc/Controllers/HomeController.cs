using Microsoft.AspNetCore.Mvc;
using PersonalWebAPPMvc.Business.Category;
using PersonalWebAPPMvc.Models;
using System.Diagnostics;

namespace PersonalWebAPPMvc.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICategoryService _categoryService;


    public HomeController(ILogger<HomeController> logger, ICategoryService categoryService)
    {
        _logger = logger;
        _categoryService = categoryService;
    }

    public IActionResult Index()
    {
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
