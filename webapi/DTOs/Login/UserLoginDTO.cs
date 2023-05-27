using System.ComponentModel.DataAnnotations;

namespace webapi.DTOs.Login;

public class UserLoginDTO
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
 
    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}