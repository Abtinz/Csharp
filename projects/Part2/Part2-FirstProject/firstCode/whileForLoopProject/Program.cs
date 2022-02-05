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
            Console.WriteLine("press eny key ");
            Console.ReadLine();
        }
    }
}
