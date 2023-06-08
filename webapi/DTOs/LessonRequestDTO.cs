namespace webapi.DTOs;

public class LessonRequestDTO
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int LessonTypeId { get; set; }
}