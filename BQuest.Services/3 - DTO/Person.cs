using BQuest.Services.Enumerators;
using System.Collections.Generic;

namespace BQuest.Services.DTO
{
    public class Person
    {
        public string Name { get; set; }

        public int Hight { get; set; }

        public string Race { get; set; }

        public GenderType Gender { get; set; }

        protected (bool,List<string>) VerifyPerson()
        {
            var validation = (true,new List<string>());

            if (string.IsNullOrEmpty(Name))
            {
                validation.Item1 = false;
                validation.Item2.Add("Name is null or empty");
            }
            if (string.IsNullOrEmpty(Race))
            {
                validation.Item1 = false;
                validation.Item2.Add("Race is null or empty");
            }
            if (Hight <= 0)
            {
                validation.Item1 = false;
                validation.Item2.Add("Hight less than or equals 0");
            }
            if (Gender <= 0)
            {
                validation.Item1= false;
                validation.Item2.Add("Gender less than or equals 0 ");
            }
            
            return validation;
        }

    }
}
