using System.Security.Claims;

namespace webapi.Services;

public interface IClaimsService
{
    Task<List<Claim>> GetUserClaimsAsync(ApplicationUser user);
}