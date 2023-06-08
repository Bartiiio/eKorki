namespace webapi.Models;

public class Lesson
{
    public int Id { get; set; }
    
    public string Description { get; set; }
    public decimal Price { get; set; }

    public virtual LessonType LessonType { get; set; }
    public virtual ApplicationUser User { get; set; }
}