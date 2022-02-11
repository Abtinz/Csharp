using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_1
{
    internal class eagle : Animal
    {
        public double FlyHeight { get; set; }

        public void flying()
        {
            Console.WriteLine(Name + " is flying at " + FlyHeight);
        }
    }
}
