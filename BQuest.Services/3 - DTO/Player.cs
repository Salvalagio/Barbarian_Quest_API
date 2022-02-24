using BQuest.Services.Enumerators;
using System.Collections.Generic;

namespace BQuest.Services.DTO
{
    public class Player : Character
    {
        public ClassType Class { get; set; }

        public Attributes Attributes { get; set; }

        public Dictionary<int,object> Valid()
        {
            var valid = true;
            List<string> property = new();

            if (string.IsNullOrEmpty(Name))
            {
                valid = false;
                property.Add("Name is null or empty");
            }
            if (string.IsNullOrEmpty(Race))
            {
                valid = false;
                property.Add("Race is null or empty");
            }
            if (Hight <= 0)
            {
                valid = false;
                property.Add("Hight less than or equals 0");
            }
            if (Gender <= 0)
            {
                valid = false;
                property.Add("Gender less than or equals 0 ");
            }
            if (Class <= 0)
            {
                valid = false;
                property.Add("Class less than or equals 0");
            }

            var ret = new Dictionary<int, object>(1);
            ret.Add(1, valid);
            ret.Add(2, property);
            return ret;

        }


    }
}
