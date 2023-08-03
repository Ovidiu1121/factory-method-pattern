using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema84__FactoryMethodPattern.models
{
    public class Tiger : Animal
    {
        public Tiger(String color)
        {
            Console.WriteLine("\nA tiger with " + color+ " color is created.");
        }

        public void displayBehavior()
        {
            Console.WriteLine("It says: Halum.");
            Console.WriteLine("It loves to roam in a jungle.");
        }
    }
}
