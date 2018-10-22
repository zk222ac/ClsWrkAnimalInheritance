using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Hippo : Animal
    {
        public Hippo(string name) : base(name)
        {

        }

        public override string Eat()
        {
            return "Hippo eat grass and vegatables";
        }

        public override string MakeNoise()
        {
            return "Hippo has churking sound";
        }

       
        public string Swim()
        {
            return "Hippo usually spend time in the water";
        }
    }
}
