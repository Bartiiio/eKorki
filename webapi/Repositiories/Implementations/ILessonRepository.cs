using Microsoft.EntityFrameworkCore;
using webapi.Models;
using webapi.Repositiories.Interfaces;

namespace webapi.Repositiories.Implementations;

public class ILessonRepository : Interfaces.ILessonRepository
{
    private readonly AppDbContext _dbContext;

    public ILessonRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Lesson> GetByIdAsync(int id)
    {
        return await _dbContext.Lessons.FindAsync(id);
    }
    
    public async Task<List<Lesson>> GetByUserId(Guid id)
    {
        return await _dbContext.Lessons.Select(lesson => lesson).Where(lesson => lesson.User.Id == id).ToListAsync();
    }

    public async Task<List<Lesson>> GetAllAsync()
    {
        return await _dbContext.Lessons.ToListAsync();
    }

    public async Task<Lesson> AddAsync(Lesson lesson)
    {
        var addedLesson = await _dbContext.Lessons.AddAsync(lesson);
        await _dbContext.SaveChangesAsync();
        return addedLesson.Entity;
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