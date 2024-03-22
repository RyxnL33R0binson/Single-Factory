using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    //This is an abstract class which means it can only declare what an object is, not create it
    abstract class Factory
    {
        //name of the device you have entered
        private string nameOfDevice;
        //name of the brand the device is
        private string brand;

        public Factory(string nme, string brand)
        {
            nameOfDevice = nme;
            this.brand = brand;
        }

        //returns the name of the device
        public string GetName()
        {
            return nameOfDevice;
        }

        //return the brand of the device
        public string GetBrand()
        {
            return brand;
        }

        //Represents the type the object as a string
        public override string ToString()
        {
            string ss = "";
            ss = ss + "Name: " + GetName() + "\nBrand: " + GetBrand();
            return ss;
        }

        //The method every sub-class must use and add data to the body
        public abstract IScreenType ScreenType(); //oledscreen


        //returns the components needed for the device(s)
        public string OrderScreen()
        {   
            var screen = ScreenType();
            return screen.TypeOfScreen();
        }

    }
}
