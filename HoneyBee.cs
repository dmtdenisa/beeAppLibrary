﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public abstract class HoneyBee : IBee
    {
        private string id;
        public string ID { 
            get => id; 
            set
            {
                id = value;
            } 
        }

        private uint age = 1;
        public uint Age { get => age; set => age = value; }
        
        private static List<string> roles;
        public static List<string> Roles
        {
            get
            {
                return roles;
            }
        }

        public static int StressLevel { get => stressLevel; set => stressLevel = value; }

        private static int stressLevel = 1;



        public HoneyBee(string id)
        {
            ID = id;
            
        }

        public HoneyBee(HoneyBee bee)
        {
            ID = bee.ID;
            Age = bee.Age;
        }

        public override string ToString()
        {
            return $"Bee id: {ID}, role: {showType()}, age: {Age}";
        }

        public string showType()
        {
            return GetType().Name;
        }

        public string DoWork()
        {
            string work= $"{showType()} {ID} is:\n";
            List<string> workload = HoneyBee.getRoles(this);
            foreach(string action in workload)
            {
                work += $"  {action}...\n";
            }
            work += $"{showType()} {ID} has fulfilled its tasks!\n";
            return work;
        }

        public static List<string> getRoles(HoneyBee bee)
        {
            List<string> output = new List<string>() { "No roles assignet yet" };
            switch (bee.GetType().Name)
            {
                case "WorkingClass":
                case "HoneyBee":
                    break;
                case "DroneBee":
                    output = DroneBee.Roles;
                    break;
                case "HiveBee":
                    output = HiveBee.Roles;
                    break;
                case "ForagerBee":
                    output = ForagerBee.Roles;
                    break;
                case "QueenBee":
                    output = QueenBee.Roles;
                    break;
                
            }
            return output;

        }
    }
}
