using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema84__FactoryMethodPattern.factories
{
    public abstract class AnimalFactory
    {
        public void createAndDisplayAnimal(String color)
        {
            Animal animal;
            animal=createAnimal(color);
            animal.displayBehavior();
        }
        protected abstract Animal createAnimal(String color);
    }
}
