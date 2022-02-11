using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_1
{
    internal class Animal
    {
        public string Name { get; set; }
        public int age { get; set; }
        public double wieght { get; set; }


        public void sleeping()
        {
            Console.WriteLine(Name+"is sleeping");
        }

        public void eating()
        {
            Console.WriteLine(Name + "is eating");
        }

        public void details()
        {
            Console.WriteLine("Animal Details" +
                              "Name: " + Name +
                              "Age: " + age +
                              "Wight" + wieght + " kg"

                );
        }


    }
}
