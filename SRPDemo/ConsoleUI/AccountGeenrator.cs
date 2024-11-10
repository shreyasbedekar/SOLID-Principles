using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AccountGeenrator
    {
        public static void GenerateUsername(Person user)
        {
            Console.WriteLine($"Your username is: {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
