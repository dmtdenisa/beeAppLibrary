using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class HiveBee : WorkingClassBee
    {
        private static readonly List<string> roles = new List<string>() {
            "Nursing larvae",
            "Attending the queen",
            "Packing pollen",
            "Ripening nectar",
            "Performing undertaker duties",
            "Attending the hive"
        };
        public static new List<string> Roles
        {
            get
            {
                return roles;
            }
        }
        public HiveBee(string id) : base(id)
        {
        }

        public static explicit operator ForagerBee(HiveBee bee)
        {
            ForagerBee transformedBee = new ForagerBee(bee.ID)
            {
                Age = bee.Age
            };
            return transformedBee;
        }
    }
}
