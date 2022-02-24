using BQuest.Services.DTO;
using BQuest.Services.Enumerators;
using BQuest.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;

namespace Barbarian_Quest_API.Controllers
{
    [Route("[Controller]")]
    public class CharacterController : Controller
    {
        private readonly IConsultCharacterService _consultCharacterService;
        private readonly ICreateCharacterService _createCharacterService;
        private readonly IDeleteCharacterService _deleteCharacterService;
        private readonly IAlterCharacterService _alterCharacterService;

        public CharacterController(IConsultCharacterService consultInterface,
                                   ICreateCharacterService createInterface,
                                   IDeleteCharacterService deleteInterface,
                                   IAlterCharacterService alterInterface)
        {
            _consultCharacterService = consultInterface;
            _createCharacterService = createInterface;
            _deleteCharacterService = deleteInterface;
            _alterCharacterService = alterInterface;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] Player player)
        {
            Dictionary<int, object> playerValidation = player.Valid();

            if (!(bool)playerValidation.GetValueOrDefault(1))
                return BadRequest(new ErrorMessage($"One of the following attributes are wrong, please verify." + 
                                    $"ps: try to verify these = {JsonSerializer.Serialize(playerValidation.GetValueOrDefault(2))}", player,null));

            return Ok();
        }

        [HttpGet]
        [Route("ConsultById")]
        public IActionResult ConsultById(int Id)
        {

            return Ok();
        }

        [HttpPut]
        [Route("AlterAttributes")]
        public IActionResult AlterAttributes([FromBody] Attributes attributes, string playerName)
        {

            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int Id)
        {

            return Ok();
        }

    }
}
