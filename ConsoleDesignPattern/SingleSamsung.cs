using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    class SingleSamsung
    {
        //Declaring what the object is
        private static SingleSamsung brand;
       
        //private constructor which will only be called/used if the object has not been created.
        private SingleSamsung()
        {

        }

        //This static method will either create the object of this class or return the existing one
        public static SingleSamsung GetInstance()
        {
            //if the object has not been created...
            if(brand == null)
            {
                //create it
                brand = new SingleSamsung();
            }
            //else return it
            return brand;
            
        }
        //Gets the prices of some Samsung devices
        public string GetPrices()
        {
            string ss = "";
            ss = ss + "Price of base S-Series: £849\nPrices of S-Series Plus: £1049\n" +
                "Prices of Galaxy Ultras: £1249.99";
            return ss;
        }

        //Represents the brand and products as a string
        public override string ToString()
        {
            string ss = "";
            ss = "You have a Samsung device\nThis device could be an: \nS-Series\nA-Series\nGalaxy Watch" +
                "\ntelevision \nlaptop\nGalaxy Tab\nSmart watch\nWashing Machine or fridge" ;
            return ss;
        }

    }
}
