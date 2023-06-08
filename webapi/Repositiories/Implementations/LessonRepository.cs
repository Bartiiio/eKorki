using Microsoft.EntityFrameworkCore;
using webapi.Models;
using webapi.Repositiories.Interfaces;

namespace webapi.Repositiories.Implementations;

public class LessonRepository : ILessonRepository
{
    private readonly AppDbContext _dbContext;

    public LessonRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Lesson> GetByIdAsync(int id)
    {
        return await _dbContext.Lessons.FindAsync(id);
    }

    public async Task<List<Lesson>> GetAllAsync()
    {
        return await _dbContext.Lessons.ToListAsync();
    }

    public async Task AddAsync(Lesson lesson)
    {
        await _dbContext.Lessons.AddAsync(lesson);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Lesson lesson)
    {
        _dbContext.Lessons.Update(lesson);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Lesson lesson)
    {
        _dbContext.Lessons.Remove(lesson);
        await _dbContext.SaveChangesAsync();
    }
}