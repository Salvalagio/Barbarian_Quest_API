using BQuest.Services.Enumerators;

namespace BQuest.Services.DTO
{
    public class Player : Character
    {
        public ClassType Class { get; set; }

        public int Strength { get; set; }

        public int Vitality { get; set; }

        public int Dexterity { get; set; }

        public int Magic { get; set; }

        public int Stealth { get; set; }

    }
}
