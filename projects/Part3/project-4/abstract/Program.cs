using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Samand();
            Car secondCar = new Pride();
            firstCar.moving();
            secondCar.moving();
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
