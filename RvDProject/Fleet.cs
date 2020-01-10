using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RvDProject
{
    public class Fleet
    {

        // member variables ---------------------------------------

        public List<Robot> robots;
        public int knifeAttack;
        public int flameThrowerAttack;
        public int rockAttack;
        public int rTeamAttack;
        public int rTeamPower;
        public int rTeamHealth;
        

        // Herd robotKillDino = new Herd();

        // constructor -----------------------------------------------

        public Fleet()
        {
            robots = new List<Robot>();
            knifeAttack = -10;
            flameThrowerAttack = -10;
            rockAttack = -10;
            rTeamAttack = -15;
            rTeamPower = 100;
            rTeamHealth = 100;
        }
        // member methods --------------------------------------------

        public void AddRobot(Robot robot)
        {
            robots.Add(robot);
        }

        public void RemoveRobot(Robot robot)
        {
            robots.Remove(robot);
        }
        public void RobotAttack(Herd herd)
        {
            herd.teamHealth += rTeamAttack;
            rTeamPower += rTeamAttack;
            Console.WriteLine(" Dino Health Remaining: " + herd.teamHealth + "\n Robot Power remaining: "+ rTeamPower);
            Console.ReadLine();
        }


    }
}
