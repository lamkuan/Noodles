using Microsoft.AspNetCore.Mvc;

namespace Noodles.controllers;

public class NoodleController : Controller
{
    // GET
    public IList<String> Index()
    {
        return new List<String> {"牛肉面", "羊肉面", "雞蛋面"};
    }
}