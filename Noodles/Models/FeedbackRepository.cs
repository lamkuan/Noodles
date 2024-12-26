using Microsoft.EntityFrameworkCore;

namespace Noodles.Models;

public class FeedbackRepository: IFeedbackRepository
{
    private readonly AppDbContext _context;

    public FeedbackRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Feedback> GetAllFeedbacks()
    {
        return _context.Feedbacks;
    }

    public void AddFeedback(Feedback feedback)
    {
        _context.Feedbacks.Add(feedback);
        _context.SaveChanges();
    }
}