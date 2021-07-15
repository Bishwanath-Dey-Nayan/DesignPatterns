using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class ConcreteVehicleFactory:VehicleFactory
    {
        public override IFactory GetVehicle(string vehicle)
        {
            switch(vehicle)
            {
                case "scooter":
                    return new Scooter();
                case "bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' can not be created", vehicle));

            }
        }
    }
}
