using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tigger tigger = new Tigger();
            eagle bird = new eagle();

            //Tigger
            tigger.Name = "Tigger";
            tigger.age = 20;
            tigger.wieght = 100;
            tigger.HuntSpeed = 20.5;

            //Eagle
            bird.Name = "Tigger";
            bird.age = 8;
            bird.wieght = 40;
            bird.FlyHeight = 300;

            tigger.details();
            bird.details();

            tigger.eating();
            bird.eating();

            tigger.sleeping();
            bird.sleeping();

            tigger.hunting();
            bird.flying();

            Console.WriteLine("press eny key to exit");
            Console.ReadLine();

        }
    }
}
