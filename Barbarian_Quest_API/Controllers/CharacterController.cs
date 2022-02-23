using BQuest.Services.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Barbarian_Quest_API.Controllers
{
    [Route("[Controller]")]
    public class CharacterController : Controller
    {
        [HttpPost]
        [Route("Create")]
        public IActionResult CreateCharacter([FromBody] Player player)
        {

            return Ok();
        }
    }
}
