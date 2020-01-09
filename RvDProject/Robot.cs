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
        public int health = 100;
        public int pwrLevel = 100;
        public string weapon;
        public int attackPwr = 15;


        // constructor (spawner)
        public Robot(string weapon, string rName)
        {
            this.weapon = weapon;
            this.rName = rName;

        }

        //member methods (can do)
    }
}
