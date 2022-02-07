using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses
{
    internal class Program
    {
        public static string fullName;
        public static string userName;
        public static string email;
        public static int phoneNumber;

        public static string courseName;
        public static string courseId;
        public static string courseTeacher;

        public static string feedBack;

        static void Main(string[] args)
        {
            signUp();
            
            while (true)
            {
                Console.WriteLine("Full name :" + fullName);
                Console.WriteLine("1) New Course");

            }
            
        }

        static void signUp()
        {
            Console.WriteLine("Please enter your name: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            fullName += Console.ReadLine();
            Console.WriteLine("Please enter your email: ");
            email = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Please enter your phone Number: ");
                string enterdPhoneNumber = Console.ReadLine();
                //numeeric check
                bool isNumeric = int.TryParse(enterdPhoneNumber, out phoneNumber);
                if (isNumeric)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error phone number is numeric!")
                }
                 
            }
             

        }
    }
}
