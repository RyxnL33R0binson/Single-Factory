using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    //This class is a sub-class of Devices. This means it must use every abstract method in the parent class
    class EReader : Factory
    {
        //colour of the EReader
        private string colour;
        public EReader(string nme, string brand, string color) : base(nme, brand)
        {
            colour = color;
        }

        //returns the colour of the EReader
        public string GetColour()
        {
            return colour;
        }


        public override IScreenType ScreenType()
        {
            return new LCDScreen();
        }
    }
}
