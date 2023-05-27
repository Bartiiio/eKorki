using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace webapi.Services;

public interface IJwtTokenService
{
    JwtSecurityToken GetJwtToken(List<Claim> userClaims);
}