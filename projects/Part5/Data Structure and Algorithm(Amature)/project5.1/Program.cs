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
                    Console.WriteLine("Dynamic Algorithm (Factorial): " + dynamicFactorial(number));
                    Console.WriteLine("Recursive Algorithm (Factorial): " + recursiveFactorial(number));
                    
                }
                else
                {
                    Console.WriteLine("Invalid Input!");

                }
            }


            
        }
        static long dynamicFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            else
            {
                long resault = 1;
                for(int currentNumber = 1 ; currentNumber <= number; currentNumber++)
                {
                    resault *= currentNumber;
                }
                return resault;

            }
            
        }

        static long recursiveFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            else
            {
                return number * recursiveFactorial(number - 1);
            }
        }
    }
}
