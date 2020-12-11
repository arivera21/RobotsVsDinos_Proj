using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs.Properties
{
    class Dinosaur
    {
        public string typeOfDinosaur;
        public int percentageHealth;
        public int energyLevel;
        public int attackPower;
        
       
     



        public Dinosaur(string typeOfDinosaur)
        {
            this.typeOfDinosaur = typeOfDinosaur;
            percentageHealth = 100;
            energyLevel = 100;
            attackPower = 15;
            Console.WriteLine("Are You Ready!" + typeOfDinosaur);

       
            {

            }
            
        }
    }
}
