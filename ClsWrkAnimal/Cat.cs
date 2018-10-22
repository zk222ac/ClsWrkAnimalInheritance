using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
   
    class Cat : Feline
    {
        public Cat(string name) : base(name)
        {
        }

        public override string MakeNoise()
        {
            return "Cat is Mowing";
        }

        public override string Eat()
        {
            return "Cat is eating ready made food";
        }

        public override string Roam()
        {
            return "Home cat usually stay at home";
        }
    }
}
