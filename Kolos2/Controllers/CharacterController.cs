using Kolos2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolos2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly IDbServices _dbService;
    public CharacterController(IDbServices dbService)
    {
        _dbService = dbService;
    }
    [HttpGet("{characterId}")]
    public async Task<IActionResult> GetCharacter(int characterId)
    {
        return Ok();
    }
}