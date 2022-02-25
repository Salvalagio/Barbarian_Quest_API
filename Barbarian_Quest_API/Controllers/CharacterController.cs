using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using BQuest.Domain.Models.DTO;
using BQuest.Services.Interfaces;
using System.Collections.Generic;

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
        public IActionResult Create([FromBody] Character newCharacter)
        {
            (bool,List<string>) playerValidation = newCharacter.Valid();

            if (!playerValidation.Item1)
                return BadRequest(new ErrorMessage($"One of the following attributes are wrong, please verify." + 
                                    $"ps: try to verify these = {JsonSerializer.Serialize(playerValidation.Item2)}", newCharacter));

            return Ok();
        }

        [HttpGet]
        [Route("ConsultByName")]
        public IActionResult ConsultByName(string characterName)
        {
            if (string.IsNullOrEmpty(characterName))
                return BadRequest(new ErrorMessage($"PlayerName that you search are incorrect. Name: {characterName}"));

            bool validName = false;

            try
            {
                validName = _consultCharacterService.ConsultValidName(characterName);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }


            if (validName)
                return Ok("Caracter name available.");
            else
                return Ok("Caracter name unavailable.");
        }

        [HttpGet]
        [Route("ConsultByPlayer")]
        public IActionResult ConsultByPlayerId(int playerId)
        {
            if (playerId <= 0)
                return BadRequest(new ErrorMessage($"PlayerId that you search are incorrect. Id: {playerId}"));

            return Ok();
        }

        [HttpPut]
        [Route("AlterAttributes")]
        public IActionResult AlterAttributes([FromBody] Attributes attributes, int playerId)
        {
            var attributesValidation = (true,new List<string>());
            attributes.VerifyAttributes(ref attributesValidation);

            if (!attributesValidation.Item1)
                return BadRequest(new ErrorMessage($"One of the following Attributes are wrong, please verify." +
                                 $"{JsonSerializer.Serialize(attributesValidation.Item2)}"));

            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int playerId)
        {
            if (playerId <= 0)
                return BadRequest(new ErrorMessage($"PlayerId that you search are incorrect. Id: {playerId}"));

            return Ok();
        }

    }
}
