using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Patterns.Pattern_AbstractFactory
{
    public interface FoodFactory
    {
        Food GetFood();
    }

    public class AppleFactory : FoodFactory
    {
        public Food GetFood()
        {
            Food fruit = new Apple();
            fruit.Name = "Apple";
            fruit.Sort = "Fruit";
            return fruit;
        }
    }

    public class BananaFactory : FoodFactory
    {
        public Food GetFood()
        {
            Food fruit = new Banana();
            fruit.Name = "Banana";
            fruit.Sort = "Fruit";
            return fruit;
        }
    }
}
