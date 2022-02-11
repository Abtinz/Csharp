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
            Triangle triangle;
            while (true)
            {
                Console.Write("Triangle Base: ");
                float firstInput = float.Parse(Console.ReadLine()); 
                if(firstInput <= 0)
                {
                    Console.WriteLine("Error the vlaue of Triangle Base is bigger the zero !");
                }
                else
                {
                    triangle = new Triangle(firstInput);
                    break;
                }
            }
            hieghtSet(triangle);
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();

        }

        public static void hieghtSet(Triangle triangle)
        {
            while (true)
            {
                Console.Write("Triangle Hieght: ");
                float secondInput = float.Parse(Console.ReadLine());
                if (secondInput <= 0)
                {
                    Console.WriteLine("Error the vlaue of Triangle Hieght is bigger the zero !");
                }
                else
                {
                    triangle.TriangleHeight = secondInput;
                    break;
                }
            }

            printResult(triangle);
        }

        public static void printResult(Triangle triangle)
        {
            float area = triangle.AreaCalculator();
            Triangle.shapeType();
            Console.WriteLine("Area (TriangleBase * TriangleHeight)/2: " + area);
        }
    }
}
