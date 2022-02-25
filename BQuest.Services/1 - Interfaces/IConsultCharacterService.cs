using BQuest.Domain.Models.DTO;
using System.Collections.Generic;

namespace BQuest.Services.Interfaces
{
    public interface IConsultCharacterService
    {

        List<Character> ConsultByPlayerId(int id);

        bool ConsultValidName(string name);

        T ConsultPlayerProperty<T>(int id, string properyName);

    }
}
