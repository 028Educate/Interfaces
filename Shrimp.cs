using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Implements the Animal Interface
    public class Shrimp : Animal
    {
        //Implementation of the Eat method declared in the interface
        public void Eat()
        {
            Console.WriteLine("I love eating Algae and only Algae. Nothing meaty for me!");
        }
    }
}
