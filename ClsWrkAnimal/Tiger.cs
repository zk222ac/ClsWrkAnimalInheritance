using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Tiger : Feline
    {
        public Tiger(string name) : base(name)
        {
        }

        public override  string MakeNoise()
        {
            return "Tiger is Chuffing";
        }

        public override  string Eat()
        {
            return "Tiger is eating flesh animals";
        }
        public override string Roam()
        {
            return "Tiger moves to a certain location";
        }
    }
}
