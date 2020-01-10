using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RvDProject
{
    public class Herd
    {
        public List<Dinosaur> dinosaurs;
        public int trexAttack;
        public int pterodactylAttack;
        public int brachiosaurusAttack;
        public int teamAttack;
        public int teamHealth;
        public int teamEnergy;
        public int teamUsedEnergy;

        // Fleet dAttackMode = new Fleet(); <- dont do this, use the parameter in the method, causes a error due to infinate loop. 



        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            trexAttack = -10;
            pterodactylAttack = -10;
            brachiosaurusAttack = -10;
            teamAttack = -10;
            teamHealth = 100;
            teamEnergy = 100;
            teamUsedEnergy = -5;

        }

        public void AddDinosaur(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }

        public void RemoveDinosaur(Dinosaur dinosaur)
        {
            dinosaurs.Remove(dinosaur);
        }
        public void DinoAttack(Fleet fleet) // <- perameter rather that adding to variables to avoid looping
        // remember to update the if else statement in the battlefield class with the parameter you create. 
        {
            fleet.rTeamHealth += teamAttack;
            teamEnergy += teamUsedEnergy;
            Console.WriteLine(" Robot Power Remaining: " + fleet.rTeamPower + " Robot Health Remaining: " + fleet.rTeamHealth + "\n Dino Energy Remaining: " + teamEnergy + " Dino Health Remaining: " + teamHealth);
            
        }

    }
}
