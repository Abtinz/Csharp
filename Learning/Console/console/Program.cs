using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //how to print in #C
            Console.Out.WriteLine("#C Cource\nhttps://maktabkhooneh.org/course/آموزش مقدماتی سی شارپ\nplease enter your personal Deatails\nname: ");
            //how to get input #C
            string name = Console.ReadLine();
            Console.Out.WriteLine("Name: "+name+"\nLast Name: ");
            string LastName = Console.ReadLine();
            Console.Out.WriteLine("Last Name: " + LastName);
        }
    }
}
