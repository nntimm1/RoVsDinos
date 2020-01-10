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
       

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
        }

        public void AddDinosaur(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }

        public void RemoveDinosaur(Dinosaur dinosaur)
        {
            dinosaurs.Remove(dinosaur);
        }

        //public void DinoAttack()
        //{
        //    int result;
        //    result = Fleet -= attackPwr;
        //    Console.WriteLine("Robot Health " + health + "Dinosaur Energy " + dinosaurs.energy);
        //    Console.ReadLine();
        //}
       
    }
}
