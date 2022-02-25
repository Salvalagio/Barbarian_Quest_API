using System.Collections.Generic;

namespace BQuest.Domain.Models.DTO
{
    public class Attributes
    {
        public int Strength { get; set; }

        public int Vitality { get; set; }

        public int Dexterity { get; set; }

        public int Magic { get; set; }

        public int Stealth { get; set; }

        public void VerifyAttributes(ref (bool, List<string>) validation)
        {
            if (Strength <= 0)
            {
                validation.Item1 = false;
                validation.Item2.Add("Strength less than or equals 0");
            }
            if (Vitality <= 0)
            {
                validation.Item1 = false;
                validation.Item2.Add("Vitality less than or equals 0");
            }
            if (Dexterity <= 0)
            {
                validation.Item1 = false;
                validation.Item2.Add("Dexterity less than or equals 0");
            }
            if (Magic <= 0)
            {
                validation.Item1 = false;
                validation.Item2.Add("Magic less than or equals 0");
            }
            if (Stealth <= 0)
            {
                validation.Item1 = false;
                validation.Item2.Add("Stealth less than or equals 0");
            }
        }

    }
}
