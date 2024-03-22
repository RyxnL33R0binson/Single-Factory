using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    class SingleApple
    {
        //Declaring what the object is
        private static SingleApple brand;

        //private constructor which will only be called/used if the object has not been created.
        private SingleApple()
        {

        }

        //This static method will either create the object of this class or return the existing one
        public static SingleApple GetInstance()
        {
            //if the object has not been created...
            if (brand == null)
            {
                //create it
                brand = new SingleApple();
            }
            //else return it
            return brand;
        }


        //Gets the prices of some Apple devices
        public string GetPrices()
        {
            string ss = "";
            ss = ss + "Price of base iPhones: £799\nPrices of iPhone 15 Plus: £899\n" +
                "Prices of iPhones pros: £999\nPrices of iPhone Pro Max: £1200";
            return ss;
        }

        //Represents the brand and products as a string
        public override string ToString()
        {
            string ss = "";
            ss = ss + "You have an Apple Product\nThis could be an: \niPhone" +
                "\niPad\niWatch\nIMac\nthe £699 wheels they sell for their special desk or more!";
            return ss;
        }

    }
}

