using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string context = "";
            StreamReader InputFile = new StreamReader(@"C:\Users\ABTIN\Documents\coding\Programming\#C Programing\Maktab Khoneh\projects\Part6\project1\TestFile.txt");
            while (!InputFile.EndOfStream)
            {
                context +=  InputFile.ReadLine() + "\r\n";
            }
            Console.WriteLine("TextFile context:\n"+context);
            StreamWriter NewFile = new StreamWriter(@"C:\Users\ABTIN\Documents\coding\Programming\#C Programing\Maktab Khoneh\projects\Part6\project1\NewFile.txt");
            NewFile.WriteLine(context);
            NewFile.Close();
            Console.WriteLine("Press any key to Exit!");
            Console.ReadLine();
        }
    }
}
