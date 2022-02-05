using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSumMultCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            String inputsData = Console.ReadLine();
            int enteredNumber = int.Parse(inputsData);

            //while Section --> sum
            int index = 1;
            int whileSumResult = 0;
            while (index <= enteredNumber)
            {
                whileSumResult += index;
                index -= -1;
            }

            Console.WriteLine("While Sum Section:\n" + whileSumResult);

            //while Section --> sum
            int SecondIndex = 1;
            int whileMultiplicationResult = 0;
            while (index <= enteredNumber)
            {
                whileSumResult += index;
                index -= -1;
            }

            Console.WriteLine("While Sum Section:\n" + whileSumResult);

            

            //exit
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
