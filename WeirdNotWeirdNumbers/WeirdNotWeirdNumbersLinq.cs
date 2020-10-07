using System;
using System.Linq;

namespace WeirdNotWeirdNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var possibleNumbers = Enumerable.Range(1, 100);
            var weirdNumbers = possibleNumbers.Where(i => i%2 != 0 || i >= 6 && i <= 50);
            var notWeirdNumbers = possibleNumbers.Concat(weirdNumbers).Distinct();
            
            int n = int.Parse(Console.ReadLine());
            if (weirdNumbers.Any(w => w == n)) 
            {
                Console.WriteLine("Weird");
            }
            else if (notWeirdNumbers.Any(nW => nW == n))
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
