using Microsoft.AspNetCore.Mvc;

namespace Noodles.controllers;

[Route("admin/[controller]/[action]")]
public class UserController : Controller
{
    // GET
    public IList<String> Index()
    {
        return new List<String> {"admin", "user"};
    }
}