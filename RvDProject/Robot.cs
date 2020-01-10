using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RvDProject
{
    public class Robot
    {
        // member variables (has a)
        public string rName;
        public int healthR;
        public int pwrLevel;
        public string weapon;
        

        // constructor (spawner)
        public Robot(string weapon, string rName)
        {
            this.weapon = weapon;
            this.rName = rName;
            healthR = 100;
            pwrLevel = 100;
        }

        //member methods (can do)


    }

}
