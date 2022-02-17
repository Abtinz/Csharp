using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceProject
{
    interface IMover
    {
        void moving();
    }

    internal class Human : IMover
    {
        public void moving()
        {
            Console.WriteLine("Human is moving!");
        }
    }

    internal class Plane : IMover
    {
        public void moving()
        {
            Console.WriteLine("Plane is moving!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(); 
            Plane plane = new Plane();
            human.moving();
            plane.moving();
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
