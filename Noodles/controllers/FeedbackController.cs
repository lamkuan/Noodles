using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Noodles.Models;

namespace Noodles.controllers;

[Authorize]
public class FeedbackController: Controller
{
    private IFeedbackRepository _feedbackRepository;

    public FeedbackController(IFeedbackRepository feedbackRepository)
    {
        _feedbackRepository = feedbackRepository;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(Feedback feedback)
    {
        if (ModelState.IsValid)
        {
            _feedbackRepository.AddFeedback(feedback);
            return RedirectToAction("FeedbackComplete");
        }

        return View();
    }

    public IActionResult FeedbackComplete()
    {
        return View(); 
    }
}