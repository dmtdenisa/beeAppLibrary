using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public abstract class HoneyBee : Bee
    {
        private string _ID;

        public string ID { get => _ID; set => _ID = value; }
        

        public string showAllInfo()
        {
            return ID;
        }

        public string showRole()
        {
            return GetType().Name;
        }
    }
}
