using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Patterns.Pattern_AbstractFactory
{
    public abstract class Food
    {
        public string Name { set; get; }
        public string Sort { set; get; }
        public abstract string Kleur();

        public override string ToString()
        {
            return "Name: " + Name + " Sort: " + Sort;
        }
    }

    public class Apple : Food
    {
        public override string Kleur()
        {
            return "Red";
        }
    }

    public class Banana : Food
    {
        public override string Kleur()
        {
            return "Geel";
        }
    }
}
