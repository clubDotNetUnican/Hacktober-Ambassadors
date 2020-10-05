using System;
using System.Collections.Generic;

// Author: id-konstantin-stepanov

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string>(3) { "Rock", "Paper", "Scissors" };
            string yourVariant, opponentVariant;
            Random rnd = new Random();

            Console.WriteLine("Which option would you choose? Write \"Rock\", \"Paper\" or \"Scissors\"!");
            Console.Write("My option is ");
            yourVariant = Console.ReadLine();

            bool correct = false;
            if (yourVariant == "Rock" || yourVariant == "Paper" || yourVariant == "Scissors")
                correct = true;

            while (correct != true)
            {
                Console.Clear();
                Console.WriteLine("Which option would you choose? Write \"Rock\", \"Paper\" or \"Scissors\"!");
                Console.Write("My option is ");
                yourVariant = Console.ReadLine();

                if (yourVariant == "Rock" || yourVariant == "Paper" || yourVariant == "Scissors")
                    correct = true;
            }

            Console.WriteLine("");

            Console.Write("Your opponent choose ");
            opponentVariant = options[rnd.Next(0, 3)].ToString();
            Console.WriteLine(opponentVariant + "!");

            Console.WriteLine("");
            Console.Write(yourVariant + " vs " + opponentVariant + " = ");

            if (yourVariant == opponentVariant)
                Console.WriteLine("Draw!");
            else
            {
                bool winRock = false, winPaper = false, winScissors = false;
                if (yourVariant == "Rock" && opponentVariant == "Scissors")
                    winRock = true;
                else if (yourVariant == "Paper" && opponentVariant == "Rock")
                    winPaper = true;
                else if (yourVariant == "Scissors" && opponentVariant == "Paper")
                    winScissors = true;

                if (winRock == true || winPaper == true || winScissors == true)
                    Console.WriteLine("You win!");
                else
                    Console.WriteLine("You lose!");
            }
        }
    }
}