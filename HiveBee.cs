using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class HiveBee : WorkingClassBee
    {
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
