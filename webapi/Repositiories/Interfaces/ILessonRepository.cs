using webapi.Models;

namespace webapi.Repositiories.Interfaces;

public interface ILessonRepository
{
    Task<Lesson> GetByIdAsync(int id);
    Task<List<Lesson>> GetAllAsync();
    Task<Lesson> AddAsync(Lesson lesson);
    Task UpdateAsync(Lesson lesson);
    Task DeleteAsync(Lesson lesson);

}