using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using webapi.DTOs;
using webapi.Models;
using webapi.Repositiories.Interfaces;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LessonsController : ControllerBase
{
    private readonly ILessonRepository _lessonRepository;
    private readonly ILessonTypeRepository _lessonTypeRepository;
    private readonly UserManager<ApplicationUser> _userManager;

    public LessonsController(ILessonRepository lessonRepository, ILessonTypeRepository lessonTypeRepository, UserManager<ApplicationUser> userManager)
    {
        _lessonRepository = lessonRepository;
        _lessonTypeRepository = lessonTypeRepository;
        _userManager = userManager;
    }

    // GET: api/lessons
    [HttpGet]
    public async Task<ActionResult<IEnumerable<LessonResponseDTO>>> GetLessons()
    {
        var lessons = await _lessonRepository.GetAllAsync();
        var lessonsDTOs = lessons.Select(lesson => new LessonResponseDTO()
        {
            Id = lesson.Id,
            FirstName = lesson.User.FirstName,
            LastName = lesson.User.LastName,
            Description = lesson.Description,
            LessonType = lesson.LessonType,
            Price = lesson.Price
        });
        return Ok(lessonsDTOs);
    }

    // GET: api/lessons/5
    [HttpGet("{id}")]
    public async Task<ActionResult<LessonResponseDTO>> GetLesson(int id)
    {
        var lesson = await _lessonRepository.GetByIdAsync(id);

        if (lesson == null)
        {
            return NotFound();
        }

        var lessonResponseDTO = new
        {
            lesson.Id,
            lesson.User.FirstName,
            lesson.User.LastName,
            lesson.Description,
            lesson.LessonType,
            lesson.Price
        };

        return Ok(lessonResponseDTO);
    }

    // POST: api/lessons
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<LessonResponseDTO>> CreateLesson(LessonRequestDTO lessonRequestDto)
    {
        var email = User.FindFirstValue(ClaimTypes.Email);
        var user = await _userManager.FindByEmailAsync(email);
        var lessonType = await _lessonTypeRepository.GetByIdAsync(lessonRequestDto.LessonTypeId);
        var lesson = new Lesson()
        {
            Price = lessonRequestDto.Price,
            Description = lessonRequestDto.Description,
            User = user,
            LessonType = lessonType
        };
        var addedLesson = await _lessonRepository.AddAsync(lesson);
        
        var lessonsDTOs = new LessonResponseDTO()
        {
            Id = lesson.Id,
            FirstName = lesson.User.FirstName,
            LastName = lesson.User.LastName,
            Description = lesson.Description,
            LessonType = lesson.LessonType,
            Price = lesson.Price
        };
        return Ok(lessonsDTOs);
    }

    // PUT: api/lessons/5
    [Authorize]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLesson(int id, Lesson lesson)
    {
        if (id != lesson.Id)
        {
            return BadRequest();
        }

        await _lessonRepository.UpdateAsync(lesson);

        return NoContent();
    }

    // DELETE: api/lessons/5
    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLesson(int id)
    {
        var lesson = await _lessonRepository.GetByIdAsync(id);

        if (lesson == null)
        {
            return NotFound();
        }

        await _lessonRepository.DeleteAsync(lesson);

        return NoContent();
    }
}


