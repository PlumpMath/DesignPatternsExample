using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Patterns.Pattern_Factory
{
    public abstract class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }


        public Car(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public abstract string Sound();

        public override string ToString()
        {
            return "Brand: " + Brand + " Name: " + Name;
        }
    }

    public class CarSports : Car
    {
        public CarSports(string name, string brand) : base(name, brand)
        {
        }

        public override string Sound()
        {
            return "Vroem I'm a sports car!";
        }
    }

    public class CarCompact : Car
    {
        public CarCompact(string name, string brand) : base(name, brand)
        {
        }

        public override string Sound()
        {
            return "Vroem I'm a compact car!";
        }
    }

    public class MotorCycle : Car
    {
        public MotorCycle(string name, string brand) : base(name, brand)
        {
        }

        public override string Sound()
        {
            return "Vroem I'm a motorcycle!";
        }
    }

    public enum CarType
    {
        Motorcycle,
        Compact,
        Sports
    }
}
