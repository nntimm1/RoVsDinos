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
        public int knifeAttack;
        public int flameThrowerAttack;
        public int rockAttack;
        public int rTeamAttack;
        public int rTeamPower;

        public Fleet()
        {
            robots = new List<Robot>();
            knifeAttack = -10;
            flameThrowerAttack = -10;
            rockAttack = -10;
            rTeamAttack = -10;
            rTeamPower = 100;
    }

        public void AddRobot(Robot robot)
        {
            robots.Add(robot);
        }

        public void RemoveRobot(Robot robot)
        {
            robots.Remove(robot);
        }
        //public int RobotAttack()
        //{

        //}

      
    }
}
