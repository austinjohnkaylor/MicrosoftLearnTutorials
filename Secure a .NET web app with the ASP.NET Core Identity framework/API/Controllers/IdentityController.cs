using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        [HttpPost("logout", Name = "Logout")]
        [Authorize]
        public async Task<IResult> Logout(SignInManager<IdentityUser> signInManager,
            [FromBody] object? empty)
        {
            if (empty == null) return Results.Unauthorized();
            await signInManager.SignOutAsync();
            return Results.Ok();
        }
    }
}
