using BQuest.Services.Enumerators;
using System.Collections.Generic;

namespace BQuest.Services.DTO
{
    public class Character : Person
    {
        public ClassType Class { get; set; }

        public Attributes Attributes { get; set; }

        public (bool, List<string>) Valid()
        {
            (bool,List<string>) validation = VerifyPerson();
            Attributes.VerifyAttributes(ref validation);

            if (Class <= 0)
            {
                validation.Item1 = false;
                validation.Item2.Add("Class less than or equals 0");
            }

            return validation;
        }


    }
}
