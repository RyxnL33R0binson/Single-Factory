using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    class LEDScreen : IScreenType
    {
        public LEDScreen()
        {

        }

        //returns the type of component it is
        public string TypeOfScreen()
        {
            return "This device has an LED display";
        }
    }
}
