using FactoryMethodPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive Bike" + miles.ToString() + "km");
        }
    }
}
