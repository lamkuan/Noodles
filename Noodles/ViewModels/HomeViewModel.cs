namespace Noodles.ViewModels;

using Noodles.Models;

public class HomeViewModel
{
    public IList<Noodle> Noodles { get; set; }
    public IList<Feedback> Feedbacks { get; set; }
}