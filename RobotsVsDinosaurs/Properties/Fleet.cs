using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs.Properties
{
    class Fleet
    {
        public List<Robot> roboList;

        public Fleet()
        {

            roboList = new List<Robot>();

            Robot optimus = new Robot("Optimus Prime", "sword", 40);
            Robot robocop = new Robot("Robocop", "shotgun",50);
            Robot terminator = new Robot("terminator", "fist of god", 100);


            roboList.Add(optimus);
            roboList.Add(robocop);
            roboList.Add(terminator);



        }


    }
}
