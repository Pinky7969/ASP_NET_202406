using Microsoft.AspNetCore.Mvc;
using Model5.Services;

namespace Model5.Controllers;
public class HomeController(IMySerivce _serivce) : Controller
{
    public IActionResult Index()
    {
        //MyService service = new();
        //Console.WriteLine(service.Id);
        //Console.WriteLine(service.Id);
        ViewData["id"] = _serivce.Id;
        return View();
    }
}
