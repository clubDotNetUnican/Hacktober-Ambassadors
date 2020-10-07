using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdNotWeridNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 - 100 and I'll tell you if its werid or not weird!");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine("Weird!");
            }

            else if (n % 2 == 0 && n >= 2 && n <= 5)
            {
                Console.WriteLine("Not Weird!");
            }

            else if (n % 2 == 0 && n >= 6 && n <= 50)
            {
                Console.WriteLine("Weird!");
            }

            else if (n % 2 == 0 && n > 50)
            {
                Console.WriteLine("Not Weird!");
            }

            Console.ReadLine();



        }
    }
}
