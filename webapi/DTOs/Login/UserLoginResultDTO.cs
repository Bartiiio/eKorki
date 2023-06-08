namespace webapi.DTOs.Login;

public class UserLoginResultDTO
{
    public string Id { get; set; }
    public bool Succeeded { get; set; }

    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public string Message { get; set; }

    public TokenDTO Token { get; set; }
}