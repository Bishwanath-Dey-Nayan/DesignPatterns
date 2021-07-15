using FactoryMethodPattern.ConcreteCreator;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Factory;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("bike");
            bike.Drive(40);

            Console.ReadKey();
        }
    }
}
