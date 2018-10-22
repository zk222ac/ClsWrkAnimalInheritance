using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>()
            {
                new Lion("Lion" ),
                new Tiger("Tiger"),
                new Cat("Cat"),
                new Hippo("Hippo"),
                new Wolf("wolf"),
                new Dog("Dog")
            };

            foreach (var lis in list)
            {
                Console.WriteLine($"Name:{lis} |, sound:{lis.MakeNoise()}");
            }

            Console.ReadKey();

        }
    }
}
