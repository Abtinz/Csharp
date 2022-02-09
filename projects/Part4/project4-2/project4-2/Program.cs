using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            string newKey;
            int newValue;

            while (true)
            {
                Console.WriteLine("Press 1 : new key\nPress 2 : show map");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("New Key: ");
                    newKey = Console.ReadLine();
                    newValue = newKey.Length;
                    map.Add(newKey, newValue);
                }
                else if (choice == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wromg Input!\nPlease enter 1 or 2");
                }
            }

            foreach(string key in map.Keys) {
                int value; 
                map.TryGetValue(key, out value);
                Console.WriteLine("key: " + key + "  value: "+value);
            }
            Console.WriteLine("press eny key to exit");
            Console.ReadLine();
        }
    }
}
