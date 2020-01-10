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
                if (fleet.rTeamHealth > 0)
                {
                    GetAttckerSelectionFromUser();
                }
                else
                {
                    Console.WriteLine("Dinos Win! \n Game Over");
                   
                }
            }
            else
            {
                fleet.RobotAttack(herd);
                if (herd.teamHealth > 0)
                {
                    GetAttckerSelectionFromUser();
                }
                else
                {
                    Console.WriteLine("Robots Win! \n Game Over");
                  
                }
            }
            
        
        }
        public void FleetRoster()
        {
            Console.WriteLine(fleet.robots);
            Console.ReadLine();
        }
    }
}
