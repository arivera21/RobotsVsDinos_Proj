using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs.Properties
{
    class Herd
    {
        public List<Dinosaur> dinoList;

        public Herd()
        {

            dinoList = new List<Dinosaur>();

            Dinosaur trex = new Dinosaur("T-Rex", 100);
            Dinosaur raptor = new Dinosaur("Raptor", 50);
            Dinosaur tricerotops = new Dinosaur("Tricerotops",75 );

            dinoList.Add(trex);
            dinoList.Add(raptor);
            dinoList.Add(tricerotops);


        }
    }
}
