using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Name Generator!");
            Person user = new Person();

            Console.WriteLine("Enter your first name:");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            user.LastName = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You must enter a valid first name.");
                Console.ReadLine();
                return;
            }
            if(string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You must enter a valid last name.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Your username is: {user.FirstName.Substring(0, 1)}{user.LastName}");
            Console.ReadLine();
        }
    }
}
