using Microsoft.AspNetCore.Mvc;
using Noodles.Models;
using Noodles.ViewModels;

namespace Noodles.controllers;

public class HomeController : Controller
{
    private INoodleRepository _noodleRepository;
    private IFeedbackRepository _feedbackRepository;

    public HomeController(INoodleRepository noodleRepository, IFeedbackRepository feedbackRepository)
    {
        _noodleRepository = noodleRepository;
        _feedbackRepository = feedbackRepository;
    }
    
    public IActionResult Index()
    {
        // var noodles = _noodleRepository.GetAllNoodles();
        var viewModel = new HomeViewModel
        {
            Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
            Noodles = _noodleRepository.GetAllNoodles().ToList(),
        };
        
        return View(viewModel);
    }
    
    public String About()
    {
        return "Your application description page.";
    }

    public IActionResult Detail(int id)
    {
        return View(_noodleRepository.GetNoodleById(id));
    }
}