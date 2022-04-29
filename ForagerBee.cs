using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class ForagerBee : WorkingClassBee
    {
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
    }
}
