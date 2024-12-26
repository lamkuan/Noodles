namespace Noodles.Models;

public interface INoodleRepository
{
    IEnumerable<Noodle> GetAllNoodles();
    Noodle GetNoodleById(int id);
}