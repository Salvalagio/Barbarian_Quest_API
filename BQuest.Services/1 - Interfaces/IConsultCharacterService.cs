using BQuest.Services.DTO;
using System.Collections.Generic;

namespace BQuest.Services.Interfaces
{
    public interface IConsultCharacterService
    {

        List<Character> ConsultPlayerId(int id);

        bool ConsultValidName(string name);

        T ConsultPlayerId<T>(int id, string properyName);

    }
}
