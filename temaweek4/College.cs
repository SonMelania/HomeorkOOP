using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public class College
    {




        public College()
        {

            Name = "necunoscut";
            foundYear = 0;
            city = "necunoscut";


        }
        public string Name;
        public int foundYear;
        public string city;


        public override string ToString()
        {
            return "alab";
        }

    }
}
