using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Application!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
        }
        public static void EnterFirstName()
        {
            Console.Write("Enter your first name:");
        }

        public static void EnterLastName()
        {
            Console.Write("Enter your last name:");
        }

        public static void DisplayValidationError(string fieldname)
        {
            Console.WriteLine($"You must enter a valid {fieldname}");
        }

    }
}
