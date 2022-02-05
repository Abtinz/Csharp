using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileForLoopProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number: ");
            String inputsData = Console.ReadLine();
            int enteredNumber = int.Parse(inputsData);

            //while Section
            int index = 1;
            String whileResult="";
            while (index <= enteredNumber)
            {
                whileResult +=index.ToString()+"\n";
                index -= -1;
            }

            Console.WriteLine("While Section:\n"+whileResult);

            //for section
            String forResult = "";
            for (int forIndex = 1; forIndex<=enteredNumber; forIndex-=-1)
            {
                forResult += forIndex.ToString() + "\n";
            }
            Console.WriteLine("for Section:\n" + whileResult);

            //exit
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
