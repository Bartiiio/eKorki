using webapi.Models;

namespace webapi.Repositiories.Interfaces;

public interface ILessonTypeRepository
{
    Task<LessonType> GetByIdAsync(int id);
    Task<List<LessonType>> GetAllAsync();
    Task AddAsync(LessonType lessonType);
    Task UpdateAsync(LessonType lessonType);
    Task DeleteAsync(LessonType lessonType);
}