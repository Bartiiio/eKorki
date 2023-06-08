using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using webapi.DTOs;
using webapi.DTOs.Login;
using webapi.Services;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly IClaimsService _claimsService;
    private readonly IJwtTokenService _jwtTokenService;

    public UserController(
        UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        IClaimsService _claimsService,
        IJwtTokenService jwtTokenService)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        this._claimsService = _claimsService;
        _jwtTokenService = jwtTokenService;
    }
 
    [HttpPost]
    [Route("register")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Register([FromBody] UserRegisterDTO userRegisterDTO)
    {
        IdentityResult result;
 
        ApplicationUser newUser = new()
        {
            FirstName = userRegisterDTO.FirstName,
            LastName = userRegisterDTO.LastName,
            UserName = userRegisterDTO.Email,
            Email = userRegisterDTO.Email,
            SecurityStamp = Guid.NewGuid().ToString(),
        };
 
        result = await _userManager.CreateAsync(newUser, userRegisterDTO.Password);
 
        if (!result.Succeeded)
            return Conflict(new UserRegisterResultDTO
            {
                Succeeded = result.Succeeded,
                Errors = result.Errors.Select(e => e.Description)
            });
 
        var token = await GetToken(newUser);
        return Ok(new UserLoginResultDTO
        {
            Succeeded = true,
            Token = token
        });
    }
    
    [HttpPost]
    [Route("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> Login([FromBody] UserLoginDTO userLoginDTO)
    {
        var user = await _userManager.FindByEmailAsync(userLoginDTO.Email);
 
        if (user != null && await _userManager.CheckPasswordAsync(user, userLoginDTO.Password))
        {
            var token = await GetToken(user);
            return Ok(new UserLoginResultDTO
            {
                Succeeded = true,
                Token = token
            });
        }
 
        return Unauthorized(new UserLoginResultDTO
        {
            Succeeded = false,
            Message = "The email and password combination was invalid."
        });
    }

    private async Task<TokenDTO> GetToken(ApplicationUser user)
    {
        var userClaims = await _claimsService.GetUserClaimsAsync(user);

        var token = _jwtTokenService.GetJwtToken(userClaims);
        var tokenDto = new TokenDTO
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Expiration = token.ValidTo
        };
        return tokenDto;
    }

    private async Task SeedRoles()
    {
        if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
            await _roleManager.CreateAsync(new ApplicationRole(UserRoles.User));
 
        if (!await _roleManager.RoleExistsAsync(UserRoles.User))
            await _roleManager.CreateAsync(new ApplicationRole(UserRoles.User));
    }
}