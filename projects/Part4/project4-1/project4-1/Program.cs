using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] numbersArray = new int[10];
            int firstNumber = 0;
            while (firstNumber < 11)
            {
                numbersArray[firstNumber++] = firstNumber;
            }

            //sum section
            int sumOfArrayNumbers = 0;
            foreach(int number in numbersArray)
            {
                sumOfArrayNumbers += number;
            }

            Console.WriteLine(sumOfArrayNumbers);
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
