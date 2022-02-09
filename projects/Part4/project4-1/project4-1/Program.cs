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
            int firstNumber = 1;
            int currentIndex;
            while (firstNumber < 11)
            {
                currentIndex = firstNumber - 1;
                numbersArray[currentIndex] = firstNumber;
                firstNumber -= -1;
            }

            //sum section
            int sumOfArrayNumbers = 0;
            foreach(int number in numbersArray)
            {
                sumOfArrayNumbers += number;
            }

            Console.WriteLine("Sum Of Array Numbers: "+sumOfArrayNumbers);


            //list 
            List<int> numbersList= new List<int>();
            int listNumber = 1;
            while (listNumber < 11)
            {

                numbersList.Add(listNumber);
                listNumber -= -1;
            }

            //sum section
            int multipactionOflistNumbers = 1;
            foreach (int number in numbersList)
            {
                multipactionOflistNumbers *= number;
            }

            Console.WriteLine("Multipaction Of List Numbers: " + multipactionOflistNumbers);

            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
