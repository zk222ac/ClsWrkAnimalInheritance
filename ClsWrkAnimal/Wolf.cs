using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Wolf : Animal 
    {
        public Wolf(string name) : base(name)
        {
            
        }
        public override string MakeNoise()
        {
            return "wolf is Howling";
        }
    }
}
