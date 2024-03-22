using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPattern
{
    /*this is an interface. All the methods are abstract which means every sub-class 
      must override all the methods and add data to the body */
    interface IScreenType
    {
        //the type of screen the device has
         string TypeOfScreen();
    }
}
