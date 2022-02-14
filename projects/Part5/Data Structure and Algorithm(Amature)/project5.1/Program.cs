using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number;
                Console.WriteLine("Please enter your number:\n" +
                                  "If you want to exit please write: Exit" );
                string enterdMassage  = Console.ReadLine();
                if (enterdMassage == "Exit")
                {
                    break;
                }
                if (int.TryParse(enterdMassage, out number))
                {

                }
                else
                {
                    Console.WriteLine("Invalid Input!");

                }
            }
        }
    }
}
