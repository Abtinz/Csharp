using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses
{
    internal class Program
    {
        //user
        public static string fullName;
        public static string email;
        public static int phoneNumber;

        //course
        public static string courseName;
        public static string courseId;
        public static string courseTeacher;
        public static string courseOrganizer;
        public static string courseDescription;
        public static Boolean courseIsSaved;

        //email
        public static string serverEmail;
        public static string emailContext;

        //feedback
        public static string feedBack;

        static void Main(string[] args)
        {
            signUp();
            courseIsSaved = false;
            serverEmail = "courseMaker@course.abn.com";
            while (true)
            {
                Console.WriteLine("Full name :" + fullName);
                Console.WriteLine("1) New Course"
                    + "\n2) Course View" + "\n3) Print Course (email)" + "\n4) contact us" + "\nElse : Exit");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    NewCourse();
                }
                else if (choice== "2")
                {
                    CourseView();
                }
                else if (choice == "3")
                {
                    emailMaker();
                }
                else if (choice == "4")
                {
                    contact();
                }
                else
                {
                    break;
                }
               
            }
            
        }

        static void signUp()
        {
            Console.Write("Please enter your name: ");
            fullName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            fullName += Console.ReadLine();
            Console.Write("Please enter your email: ");
            email = Console.ReadLine();
            while (true)
            {
                Console.Write("Please enter your phone Number: ");
                string enterdPhoneNumber = Console.ReadLine();
                //numeric check
                bool isNumeric = int.TryParse(enterdPhoneNumber, out phoneNumber);
                if (isNumeric)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error phone number is numeric!");
                }
                 
            }
             
        }


        static void NewCourse()
        {
            Console.Write("Course Name: ");
            courseName = Console.ReadLine();
            Console.Write("Course ID: ");
            courseId = Console.ReadLine();
            Console.Write("Course Teacher: ");
            courseTeacher = Console.ReadLine();
            Console.Write("Course Organizer: ");
            courseOrganizer = Console.ReadLine();
            Console.Write("Course Description: ");
            courseDescription = Console.ReadLine();
            courseIsSaved = true;
        }

        static void CourseView()
        {
            if (courseIsSaved)
            {
                Console.WriteLine("Course Name: "+courseName+
                             "\nCourse ID: " + courseId +
                             "\nCourse Teacher: " +  courseTeacher +
                             "\nCourse Organizer: " + courseOrganizer +
                             "\nCourse Description: " + courseDescription
                    );
                Console.Write("press eny key for main pannel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("you have not completed your course form");
                Console.Write("press eny key for main pannel");
                Console.ReadLine();
            }
        }

        static void emailMaker()
        {
            if (courseIsSaved)
            {
                setemailMaker();
                Console.Write(emailContext);
                Console.Write("\npress eny key for main pannel");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("you have not completed your course form");
                Console.Write("press eny key for main pannel");
                Console.ReadLine();
            }
        }
        static void setemailMaker()
        {
            emailContext = "-------------------------------------------------------------------\n" +
                           "From: " + serverEmail +
                           "\nTo: " + email +
                           "\nDear " + fullName + "\nThis is your course print\nPlease save it!" +
                           "\nCourse Details: " +
                           "\nCourse Name: " + courseName +
                             "\nCourse ID: " + courseId +
                             "\nCourse Teacher: " + courseTeacher +
                             "\nCourse Organizer: " + courseOrganizer +
                             "\nCourse Description: " + courseDescription+
                             "\n-------------------------------------------------------------------";
        }

        static void contact()
        {
            //serverEmail is fake !
            Console.WriteLine("Git Hub: Abtinz"+"\nEmail: "+serverEmail);
            Console.Write("press eny key for main pannel");
            Console.ReadLine();
        }
    }
}

