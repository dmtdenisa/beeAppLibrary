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

        public static new int StressLevel { get => 2;}

        public DroneBee(string id) : base(id)
        {
            
        }

        public DroneBee(DroneBee bee) : base(bee)
        {
        }

        public override string DoWork()
        {
            return $"{base.DoWork()}This bee can now rest!\n";
        }
    }
}
