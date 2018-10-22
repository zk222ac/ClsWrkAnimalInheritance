using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    // Base Class
    class Animal
    {
        // 
        private int _id;
        private string _name;
        private string _picture;
        protected string _food;
        protected string _boundries;

        // constructor 
        public Animal(string name )
        {
            _name = name;
        }

        public virtual string MakeNoise()
        {
            return "Every animal make a noise";
        }
        public virtual string Eat()
        {
            return "Every animal has a eating habit";
        }

        public virtual string Sleep()
        {
            return "Every animal sleeps in a certain time";
        }

        public virtual string Roam()
        {
            return "some animals is moving to a certain boundries";
        }

        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
