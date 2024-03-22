using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            //*****************************************Singleton Section**********************************//

            //container for the Samsung Singleton class 
            SingleSamsung samsung = SingleSamsung.GetInstance();
            //calls the GetPrice() which will return the prices of Samsung devices
            Console.WriteLine(samsung.GetPrices()+"\n");
            //calls the ToString() which returns the Samsung class (because the constructor is private) as a string
            Console.WriteLine(samsung.ToString() + "\n\n\n\n");

            //container for the Apple Singleton class 
            SingleApple apple = SingleApple.GetInstance();
            //calls the GetPrice() which will return the prices of Apple devices
            Console.WriteLine(apple.GetPrices() + "\n");
            //calls the ToString() which returns the Apple class (because the constructor is private) as a string
            Console.WriteLine(apple.ToString()+ "\n");


            //*******************************************Factory Section*************************************//

            var galaxyS23 = new Phone("Galaxy S23","Samsung".ToLower(), 6.7);

            //IScreenType galaxyScreen = galaxyS23.CreateScreen();
            Console.WriteLine(galaxyS23.OrderScreen());

            //var watch = new FitnessWatch("Rolex", "Apple".ToLower(), "Unisex");
            //Console.WriteLine(watch.ScreenType() + "\n");

            //var kindle = new EReader("Paperwhite", "Kindle".ToLower(), "White");
            //Console.WriteLine(kindle.ScreenType() + "\n");

            Console.ReadLine();

        }

       
    }
}
