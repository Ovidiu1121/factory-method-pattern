using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema84__FactoryMethodPattern.models;

namespace Tema84__FactoryMethodPattern.factories
{
    public class DogFactory : AnimalFactory
    {
        protected override Animal createAnimal(string color)
        {
            return new Dog(color);
        }
    }
}
