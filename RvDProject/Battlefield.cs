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

        Fleet fleet = new Fleet();

        Herd herd = new Herd();


        // Constructor
        
            

        // Member Methods

        public void RunGame()
        {
             GetAttckerSelectionFromUser();
           
        }

     
        public void GetAttckerSelectionFromUser()
        {
            Console.WriteLine("Choose your attacker: \n1 Dinosaurs \n2 Robots");
            string UserInput = Console.ReadLine();
            if (UserInput == "1") 
            {
                herd.DinoAttack(fleet);
            }
            else
            {
                fleet.RobotAttack(herd);
            }
            
        
        }
        public void FleetRoster()
        {
            Console.WriteLine(fleet.robots);
            Console.ReadLine();
        }
    }
}
