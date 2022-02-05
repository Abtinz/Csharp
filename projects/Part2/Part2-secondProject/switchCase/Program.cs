using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            String firstinputsData = Console.ReadLine();
            int firstNumber = int.Parse(firstinputsData);

            Console.Write("Please enter your second number: ");
            String secondinputsData = Console.ReadLine();
            int secondNumber = int.Parse(secondinputsData);

            Console.Write("Please enter your Function Character: ");
            String thirdinputsData = Console.ReadLine();
            char character = char.Parse(thirdinputsData);

            int resault = 0;

            switch (character)
            {
                case '+':
                    resault = firstNumber + secondNumber;
                    Console.WriteLine("Sum Resault: " + resault);
                    break;

                case '-':
                    resault = firstNumber - secondNumber;
                    Console.WriteLine("Minus Resault: " + resault);
                    break;


                case '*':
                    resault = firstNumber * secondNumber;
                    Console.WriteLine("Multipaction Resault: " + resault);
                    break;

                case '/':
                    resault = firstNumber / secondNumber;
                    Console.WriteLine("Devide Resault: " + resault);
                    break;


                default:
                    Console.WriteLine("Wrong input!");
                    break;


            }

          
           
            //exit
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
