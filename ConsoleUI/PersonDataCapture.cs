using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();

            StandardMessages.EnterFirstName();
            output.FirstName = Console.ReadLine();

            StandardMessages.EnterLastName();
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
