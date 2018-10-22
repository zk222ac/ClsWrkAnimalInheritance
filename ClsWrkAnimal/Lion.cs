using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Lion : Feline 
    {
        public Lion(string name) : base(name)
        {

        }
        public override string MakeNoise()
        {
            return "Lion is roaring";
        }

        public override string Eat()
        {
            return "Lion eats flesh animals";
        }

        
    }
}
