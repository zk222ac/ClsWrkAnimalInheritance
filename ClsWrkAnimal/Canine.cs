using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Canine :Animal
    {
        public Canine(string name) : base(name)
        {

        }

        public override string Eat()
        {
            return "Canine family members have same eating habit";
        }
        public override string Sleep()
        {
            return "Canine family members have same sleeping habit";
        }
    }
}
