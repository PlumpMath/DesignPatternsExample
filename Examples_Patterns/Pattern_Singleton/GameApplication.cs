using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Patterns.Pattern_Singleton
{
    sealed class GameApplication
    {
        private static GameApplication _instance = new GameApplication();

        public string Name { get; set; }

        public static GameApplication GetInstance()
        {
            return _instance;
        }

        private GameApplication() { }

        public override string ToString()
        {
            return "This is a GameApplication! Name: " + Name; 
        }
    }
}
