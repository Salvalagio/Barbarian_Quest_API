using BQuest.Services.Enumerators;

namespace BQuest.Services.DTO
{
    public class Character : Attributes
    {
        public string Name { get; set; }

        public int Hight { get; set; }

        public string Race { get; set; }

        public GenderType Gender { get; set; }

    }
}
