using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstCourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalList = new Animal[]
            {
                new Animal("pisica", "miau"),
                new Animal("caine", "ham"),
                new Animal("urs", "moor"),
                new Animal("dragon", "wooooo"),
                new Animal("sarpe", "ssss")
            };

            foreach(Animal element in animalList)
            {
                Console.WriteLine(element.Name + " makes " + element.Sound);
            }
            Console.ReadKey();
        }
    }
}
