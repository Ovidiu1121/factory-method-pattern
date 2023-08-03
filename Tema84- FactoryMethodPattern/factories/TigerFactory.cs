using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema84__FactoryMethodPattern.models;

namespace Tema84__FactoryMethodPattern.factories
{
    public class TigerFactory : AnimalFactory
    {
        protected override Animal createAnimal(string color)
        {
            return new Tiger(color);
        }
    }
}
