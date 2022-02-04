using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportViza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to passport central system\nPlease Fill this form for your travle");

            String name;
            String lastName;
            String destenition;
            String nation;
            int day = 1;
            const int costPerDay = 1000;//this is for permission to leave the country cost claculation
            int finallCost;

            Console.Write("Sure Name: ");
            name = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Nation: ");
            nation = Console.ReadLine();
            
            Console.Write("Trip Destenition: ");
            destenition = Console.ReadLine();

            Console.Write("Duration of trip (Day): ");
            String DayTemp = Console.ReadLine();
            day = int.Parse(DayTemp);
            finallCost = day * costPerDay;

            Console.Write("Sure Name: " + name + "\nLast Name: "+lastName + "\nNation: "+nation
                             + "\nTrip Destenition: " + destenition + "\nDuration of trip (Day): " + day
                             +"\n---------------------------------------------------------------"
                             + "\nThe finall cost of the permission to leave the country (Toman):"+finallCost+
                             "\nWhishing you a good trip"+
                             "\n---------------------------------------------------------------"

                               );
        }
    }
}
