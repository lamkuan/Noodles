namespace Noodles.Models;

public interface IFeedbackRepository
{
    IEnumerable<Feedback> GetAllFeedbacks();
    void AddFeedback(Feedback feedback);
}