using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RvDProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Herd herd = new Herd();
            Dinosaur dinosaur = new Dinosaur("T-Rex");
            herd.AddDinosaur(dinosaur);
            Dinosaur dinosaur1 = new Dinosaur("Pterodactyl");
            herd.AddDinosaur(dinosaur1);
            Dinosaur dinosaur2 = new Dinosaur("Brachiosaurus");
            herd.AddDinosaur(dinosaur2);


            Fleet fleet = new Fleet();
            Robot robot = new Robot("Rock", "Phillip");
            fleet.AddRobot(robot);
            Robot robot1 = new Robot("Flame Thrower", "Raul");
            fleet.AddRobot(robot1);
            Robot robot2 = new Robot("Knife", "Stu");
            fleet.AddRobot(robot2);


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
