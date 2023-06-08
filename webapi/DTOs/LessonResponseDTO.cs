using webapi.Models;

namespace webapi.DTOs;

public class LessonResponseDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public LessonType LessonType { get; set; }
}