using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Dog : Canine
    {
        public Dog(string name) : base(name)
        {

        }

        public override string MakeNoise()
        {
            return "Dog is barking";
        }
    }
}
