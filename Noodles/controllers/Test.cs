using Microsoft.AspNetCore.Mvc;

namespace Noodles.controllers;

[Controller]
public class TestController : Controller
{
    public ActionResult Index()
    {
        return Content("Hello From Test Index");
    }
    
    public String About()
    {
        return "Hello From Test About";
    }
    
    public ActionResult Contact()
    {
        return View();
    } 
}