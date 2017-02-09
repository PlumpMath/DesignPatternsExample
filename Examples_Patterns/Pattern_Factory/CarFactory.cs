using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Patterns.Pattern_Factory
{
    public class CarFactory
    {
        public Car GetCar(CarType type, string name, string brand)
        {
            Car car = null;
            if (type == CarType.Compact) car = new CarCompact(name, brand);
            if (type == CarType.Sports) car = new CarSports(name, brand);
            if (type == CarType.Motorcycle) car = new MotorCycle(name, brand);
            if (car != null) return car;
            throw new Exception("Unknown sort of car.");
        }
    }
}
