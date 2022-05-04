using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class BeeColony : List<HoneyBee>
    {
        private int maxBees;

        public BeeColony(int capacity) : base(capacity)
        {
            maxBees=capacity;
        }

        public override string ToString()
        {
            string output = "Bee colony inhabitants:\n";
           foreach(HoneyBee bee in this)
            {
                output += $"{bee.ToString()}\n";
            }
            output += $"Maximum inhabitants: {maxBees}\nTotal inhabitants: {this.Count()}";
            return output;
        }

        
        
    }
}
