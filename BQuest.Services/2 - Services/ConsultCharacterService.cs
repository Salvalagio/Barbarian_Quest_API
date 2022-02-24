using BQuest.Services.DTO;
using BQuest.Services.Interfaces;
using System.Collections.Generic;

namespace BQuest.Services
{
    public class ConsultCharacterService : IConsultCharacterService
    {

        public ConsultCharacterService() 
        {
        }

        public List<Character> ConsultPlayerId(int id)
        {
            throw new System.NotImplementedException();
        }

        public T ConsultPlayerId<T>(int id, string properyName)
        {
            throw new System.NotImplementedException();
        }

        public bool ConsultValidName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
