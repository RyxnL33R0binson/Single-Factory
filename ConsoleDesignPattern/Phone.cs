using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    //This class is a sub-class of Devices. This means it must use every abstract method in the parent class

    class Phone : Factory
    {
        //screen size of the device
        private double screenSize;

        //brand of the device
        private string brand;

        public Phone(string nme, string brand,double size) : base(nme, brand)
        {
            screenSize = size;
            this.brand = brand;
        }

        //Returns the screen size of the phone
        public double GetSize()
        {
            return screenSize;
        }

        //Calls and returns the ToString() method in the singleton classes
        public string GetBrandDetails()
        {
            string ss = "";

           /*We cannot create an object of the Singleton because the constructor is private, so we create a variable,
            and call the static method, which does not require an object
            */
            SingleApple apple = SingleApple.GetInstance();
            SingleSamsung samsung = SingleSamsung.GetInstance();

            //if the brand of the users phone is Apple...
            if(brand == "apple".ToLower())
            {
                //return the ToString() method in the SingleApple class
                return ss + apple.ToString();
            }
            //if the brand of the users phone is Samsung...
            else if(brand == "samsung".ToLower())
            {
                //return the ToString() method in the SingleSamsung class
                return ss + samsung.ToString();
            }
            return ss;
        }
        //Represents the type of product as a string
        public override string ToString()
        {
            string ss = "";
            ss = ss + base.ToString() + "\nSize of screen: " + GetSize();
            return ss;
        }

        //Returns the components needed for the device. In this case, a screen and speakers
        public override IScreenType ScreenType()
        {
            return new OLEDScreen();
        }
    }
}
