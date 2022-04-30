using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class DroneBee : HoneyBee
    {
        private static readonly List<string> roles = new List<string>() {"Mating"};
        public static new List<string> Roles
        {
            get
            {
                return roles;
            }
        }
        public DroneBee(string id) : base(id)
        {
            
        }

        public DroneBee(DroneBee bee) : base(bee)
        {
        }
    }
}
