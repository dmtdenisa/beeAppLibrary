using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class QueenBee : HoneyBee
    {
        private static readonly List<string> roles = new List<string>() { "Producing chemical scents", "Laying eggs" };
        public static new List<string> Roles
        {
            get
            {
                return roles;
            }
        }

        public QueenBee(string id) : base(id)
        {
            
        }

        
    }
}
