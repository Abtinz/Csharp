using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_1
{
    internal class Tigger : Animal
    {
        public double HuntSpeed { get; set; }

        public void hunting()
        {
            Console.WriteLine(Name + " is hunting with " + HuntSpeed +" (km) speed");
        }
    }
}
