using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace beeAppLibrary
{
    public class Hive
    {
        public static DateTime _dateOfCreation = DateTime.Now;
        private uint _stressLevel { get; set; }
        public const uint maxStressLevel = 100;
        public int NumberOfInhabitants { get => _inhabitants.Count(); private set => numberOfInhabitants = value; }

        public BeeColony _inhabitants;
        private int numberOfInhabitants;




        static Hive()
        {
            _dateOfCreation = DateTime.Now;
        }

        public Hive()
        {
            _inhabitants = new BeeColony(20);
            _stressLevel = 0;
            
        }

        public void AddStressLevel(uint level)
        {
            _stressLevel += level;
        }

        public void ReduceStressLevel(uint level)
        {
            _stressLevel -= level;
        }


    }
}
