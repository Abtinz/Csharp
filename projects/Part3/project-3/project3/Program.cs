﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();
            while(numbers.Count < 5)
            {
                if (numbers.Count < 2)
                {
                    Console.WriteLine("Please enter a new number");
                    numbers.Add(int.Parse(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("Numbers Count: " + numbers.Count +
                                      "\nyou can enter four or three or two number to average!\n" +
                                      "if you want to exit type exit:(if you dont please press enter)" );
                    string choice = Console.ReadLine();
                    if (choice == "exit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a new number");
                        numbers.Add(int.Parse(Console.ReadLine()));
                    }
                    
                }
                
            }
            calculateAverage(numbers);           
        }

        public static void calculateAverage(List<int> numbers)
        {

            Console.WriteLine("Numbers List:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            if (numbers.Count == 2)
            {
                Console.WriteLine("Average: " + Calculator.Average(numbers[0], numbers[1]));
            }
            else if (numbers.Count == 3)
            {
                Console.WriteLine("Average: " + Calculator.Average(numbers[0], numbers[1], numbers[2]));
            }
            else if (numbers.Count == 4)
            {
                Console.WriteLine("Average: " + Calculator.Average(numbers[0], numbers[1], numbers[2], numbers[3]));
            }
        }
    }
}
