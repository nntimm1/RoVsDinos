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

        Fleet dAttackMode = new Fleet();


               
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            trexAttack = -10;
            pterodactylAttack = -10;
            brachiosaurusAttack = -10;
            teamAttack = -10;
            teamHealth = 100;
        }

        public void AddDinosaur(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }

        public void RemoveDinosaur(Dinosaur dinosaur)
        {
            dinosaurs.Remove(dinosaur);
        }
        public void DinoAttack()
        {
            dAttackMode.rTeamPower += teamAttack;

            Console.WriteLine(dAttackMode.rTeamPower);
            Console.ReadLine();

        }



    }
}
/