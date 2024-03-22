using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    class OLEDScreen : IScreenType
    {
        public OLEDScreen()
        {
            TypeOfScreen();
        }

        //returns the type of component it is
        public string TypeOfScreen()
        {
            return "This device now has an OLED display";
        }

    }
}
