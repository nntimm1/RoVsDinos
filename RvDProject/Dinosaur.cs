using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RvDProject
{
    public class Dinosaur
    {
        // member variables (has a)
        public string dinoType;
        public int healthD;
        public int energy;
        


        // constructor (spawner)
        public Dinosaur(string dinoType)
        {
            this.dinoType = dinoType;
            healthD = 100;
            energy = 100;                      
        }
     
        //member methods (can do)


    }

}
