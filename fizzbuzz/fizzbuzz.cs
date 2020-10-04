using System;

/* Author: @jotagarciaz */

namespace fizzbuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++) { 
                string fizzbuzzstring = "";
                if (i % 3 == 0)
                    fizzbuzzstring += "fizz";
                if (i % 5 == 0)
                    fizzbuzzstring += "buzz";
                if (fizzbuzzstring == "")
                   fizzbuzzstring = String.Format("{0}",i);
                
                Console.WriteLine(fizzbuzzstring);
            }
        }
    }
}
