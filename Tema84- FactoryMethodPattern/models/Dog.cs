using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema84__FactoryMethodPattern.models
{
    internal class Dog : Animal
    {

        public Dog(String color)
        {
            Console.WriteLine("\nA dog with " + color+ " color is created.");
        }
        public void displayBehavior()
        {
            Console.WriteLine("It says: Bow-Wow.");
            Console.WriteLine("It prefers barking.");
        }

    }
}
