using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Helper
{
   public class InputHelper
    {
        public int GetIntFromConsole(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            } else
            {
                Console.WriteLine("Wrong input form. Please try again");
                return GetIntFromConsole(message);
            }
        }
    }
}
