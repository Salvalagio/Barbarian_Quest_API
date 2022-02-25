using BQuest.Domain.Interfaces.Business;
using BQuest.Domain.Models.DTO;
using BQuest.Services.Interfaces;
using System.Collections.Generic;

namespace BQuest.Services
{
    public class ConsultCharacterService : IConsultCharacterService
    {
        private readonly IConsultCharacter _consultCharacter;

        public ConsultCharacterService(IConsultCharacter consultCharacter) 
        {
            _consultCharacter = consultCharacter;
        }

        public List<Character> ConsultByPlayerId(int id)
        {
            throw new System.NotImplementedException();
        }

        public T ConsultPlayerProperty<T>(int id, string properyName)
        {
            throw new System.NotImplementedException();
        }

        public bool ConsultValidName(string name) =>
            _consultCharacter.VerifyName(name);

    }
}
