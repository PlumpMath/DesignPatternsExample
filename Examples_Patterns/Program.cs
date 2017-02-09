using Examples_Patterns.Pattern_Factory;
using Examples_Patterns.Pattern_Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER TO CONTINUE TO NEXT PATTERN..\n1 = Factory Method\n2 = Singleton");
            List<Car> cars = new List<Car>();

            CarFactory factory = new CarFactory();
            cars.Add(factory.GetCar(CarType.Compact, "Peugotje", "Peugot"));
            cars.Add(factory.GetCar(CarType.Motorcycle, "Hondatje", "Honda"));
            cars.Add(factory.GetCar(CarType.Sports, "Lambotje", "Lambo"));

            foreach (Car c in cars)
            {
                Console.WriteLine(c);
                Console.WriteLine(c.Sound() + "\n");
            }
            Console.ReadLine();

            GameApplication appl = GameApplication.GetInstance();
            appl.Name = "Pakimon Go";
            Console.WriteLine(appl);
            //Using the default constructor doesn't work for the GameApplication class! Neither does inheriting from this class work.
            Console.ReadLine();
        }
    }
}
