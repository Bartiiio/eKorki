using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Repositiories.Interfaces;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LessonTypesController : ControllerBase
{
    private readonly ILessonTypeRepository _lessonTypeRepository;

    public LessonTypesController(ILessonTypeRepository lessonTypeRepository)
    {
        _lessonTypeRepository = lessonTypeRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LessonType>>> GetLessonTypes()
    {
        var lessonTypes = await _lessonTypeRepository.GetAllAsync();
        return Ok(lessonTypes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LessonType>> GetLessonType(int id)
    {
        var lessonType = await _lessonTypeRepository.GetByIdAsync(id);

        if (lessonType == null)
        {
            return NotFound();
        }

        return Ok(lessonType);
    }

    [HttpPost]
    public async Task<IActionResult> CreateLessonType(LessonType lessonType)
    {
        await _lessonTypeRepository.AddAsync(lessonType);

        return CreatedAtAction(nameof(GetLessonType), new { id = lessonType.Id }, lessonType);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLessonType(int id)
    {
        var lessonType = await _lessonTypeRepository.GetByIdAsync(id);

        if (lessonType == null)
        {
            return NotFound();
        }

        await _lessonTypeRepository.DeleteAsync(lessonType);

        return NoContent();
    }
}
