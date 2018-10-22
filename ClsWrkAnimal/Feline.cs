using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Feline : Animal
    {
        public Feline(string name) : base(name)
        {

        }

        public override string Roam()
        {
            return "Feline family members have same roaming habits";
        }
    }
}
