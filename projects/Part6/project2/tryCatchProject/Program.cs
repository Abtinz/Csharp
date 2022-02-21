using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to exit please write \"EXIT\"");
            while (true)
            {
                Console.Write("Please enter your number: ");
                string enterdStatement = Console.ReadLine();

                if(enterdStatement == "EXIT")
                {
                    break;
                }
                else
                {
                    try
                    {
                        int number = int.Parse(enterdStatement);
                        Console.WriteLine("Entered Number: "+number + "\nresult(2*number): "+ (number*2));
                    }catch (Exception exeption)
                    {
                        Console.WriteLine("Enterd value is invalid!\nplease type a number or write \"EXIT\" to exit");
                    }
                }
            }
        }
    }
}
