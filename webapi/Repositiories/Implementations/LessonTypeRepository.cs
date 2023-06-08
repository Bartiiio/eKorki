using Microsoft.EntityFrameworkCore;
using webapi.Models;
using webapi.Repositiories.Interfaces;

namespace webapi.Repositiories.Implementations;

public class LessonTypeRepository : ILessonTypeRepository
{
    private readonly AppDbContext _dbContext;

    public LessonTypeRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<LessonType> GetByIdAsync(int id)
    {
        return await _dbContext.LessonTypes.FindAsync(id);
    }

    public async Task<List<LessonType>> GetAllAsync()
    {
        return await _dbContext.LessonTypes.ToListAsync();
    }

    public async Task AddAsync(LessonType lessonType)
    {
        await _dbContext.LessonTypes.AddAsync(lessonType);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(LessonType lessonType)
    {
        _dbContext.LessonTypes.Update(lessonType);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(LessonType lessonType)
    {
        _dbContext.LessonTypes.Remove(lessonType);
        await _dbContext.SaveChangesAsync();
    }
}