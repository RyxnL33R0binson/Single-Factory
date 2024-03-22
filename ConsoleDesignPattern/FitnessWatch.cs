using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    //This class is a sub-class of Devices. This means it must use every abstract method in the parent class

    class FitnessWatch : Factory
    {
        private string gender;
        public FitnessWatch(string nme, string bran, string gen) : base(nme, bran)
        {
            gender = gen;
        }

        //Returns what the product is made for
        public string GetGender()
        { 
            return gender; 
        }

        //Represents description of the brand and product as a string
        public override string ToString()
        {
            string ss = "";
            ss = ss + base.ToString() + "\nGender: " + GetGender();
            return ss;
        }

        //Returns the components needed for the device. In this case a speakers
        public override IScreenType ScreenType()
        {
            return new LEDScreen();
        }
    }
}
