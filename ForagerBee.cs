using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class ForagerBee : WorkingClassBee
    {
        private static readonly List<string> roles = new List<string>() {
            "Collecting nectar and pollen",
            "Collecting propolis",
            "Collecting water",
            "Guarding the hive",
        };
        public static new List<string> Roles
        {
            get
            {
                return roles;
            }
        }
        public ForagerBee(string id) : base(id)
        {
        }

        public static explicit operator HiveBee(ForagerBee bee)
        {
            HiveBee transformedBee = new HiveBee(bee.ID)
            {
                Age = bee.Age
            };
            return transformedBee;
        }

        public override string DoWork()
        {
            return $"{base.DoWork()}Looks like {ID} brought some resources!\n";
        }
    }
}
