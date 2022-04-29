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
        public uint Age { get => _age; set => _age = value; }

        private uint _age;
        
        public HoneyBee(string id)
        {
            ID = id;
            Age = 1;
        }
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
