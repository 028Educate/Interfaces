using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shark and Shrimp Object
            Shark cShark = new Shark();
            Shrimp lenny = new Shrimp();

            //Call the Eat method
            cShark.Eat();
            lenny.Eat();
        }
    }
}
