using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace beeAppLibrary
{
    public class Hive
    {
        public static DateTime _dateOfCreation;

        static Hive()
        {
            _dateOfCreation = DateTime.Now;
        }
    }
}
