using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs.Properties
{
    class Robot
    {
        //Member Variables
        public string robotName;
        public int percentageHealth;
        public int powerLevel;
        public Weapon weapon;

        //constructor
        public Robot(string robotName,string weaponType,int weaponPower)
        {
           this.robotName = robotName;
           percentageHealth = 100;
           powerLevel = 100;
            weapon = new Weapon(weaponType, weaponPower);
           
           Console.WriteLine("Are You Ready!" + robotName);
            

        }


        //member methods (CAN DO)


    }

}
