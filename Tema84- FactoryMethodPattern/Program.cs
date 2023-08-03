

using Tema84__FactoryMethodPattern.factories;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("***Factory Method pattern modified demonstration.***");


        AnimalFactory factory;
        // Create a tiger and display its behavior
        // using TigerFactory.
        factory =new TigerFactory();
        factory.createAndDisplayAnimal("yellow");
        // Create a dog and display its behavior
        // using DogFactory.
        factory = new DogFactory();
        factory.createAndDisplayAnimal("white");

    }
}
