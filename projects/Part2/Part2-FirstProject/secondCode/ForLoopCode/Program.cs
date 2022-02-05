using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            String inputsData = Console.ReadLine();
            int enteredNumber = int.Parse(inputsData);

            //for Section --> sum
            int forSumResult = 0;
            for (int index = 1; index <= enteredNumber; index+=1)
            {
                forSumResult += index;
            }

            Console.WriteLine("for Sum Section:\n" + forSumResult);

            //for Section --> sum
            int forMultiplicationResult = 1;
            for (int indexMultiplication = 1; indexMultiplication <= enteredNumber; indexMultiplication += 1)
            {
                forMultiplicationResult *= indexMultiplication;
            }

            Console.WriteLine("for Multiplication Section:\n" + forMultiplicationResult);

            //exit
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }

    }
    
}
