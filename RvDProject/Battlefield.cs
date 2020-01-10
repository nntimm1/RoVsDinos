using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RvDProject
{
    public class Battlefield
    {
        // Mamber Variables 

        int DinoAt;
        int RoboAt;
        Fleet fleet = new Fleet();
        Herd herd = new Herd();

        // Constructor
        
            

        // Member Methods

        public void RunGame()
        {
            bool DinosAttack = GetAttckerSelectionFromUser();
            herd.DinoAttack();

        }

     
        public bool GetAttckerSelectionFromUser()
        {
            Console.WriteLine("Choose your attacker: \n1 Dinosaurs \n2 Robots");
            string UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void FleetRoster()
        {
            Console.WriteLine(fleet.robots);
            Console.ReadLine();
        }
    }
}
