using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RvDProject
{
    public class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();
        }

        public void AddRobot(Robot robot)
        {
            robots.Add(robot);
        }

        public void RemoveRobot(Robot robot)
        {
            robots.Remove(robot);
        }

        //public void RoboAttack()
        //{
        //    int result;
        //    result = Dinosaur.health -= attackPwr;
        //    result1 = 
        //    Console.WriteLine("Dinosaur Health " + result + "Robot Energy " + Robot.energy);
        //    Console.ReadLine();
        //}
    }
}
