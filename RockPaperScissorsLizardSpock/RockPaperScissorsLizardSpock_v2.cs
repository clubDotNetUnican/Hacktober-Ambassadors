using System;
using System.Collections.Generic;

//@author: jotagarciaz

namespace rockpaperscissoslizardspock
{
    class MainClass
    {
        public static Boolean FindWinner(List<KeyValuePair<string,string>> materials, string user_material,string computer_material)
        {
            foreach(KeyValuePair< string, string> m in materials)
            {
                if (m.Key == user_material && m.Value == computer_material){
                    return true;
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            const string ROCK = "Rock";
            const string PAPER = "Paper";
            const string SCISSOR = "Scissor";
            const string LIZARD = "Lizard";
            const string SPOCK = "Spock";

            var rand = new Random();

            //For play again    
            while (true) {
                Console.WriteLine(String.Format("\nChoices are: \n\t1.{0} \n\t2.{1} \n\t3.{2} \n\t4.{3} \n\t5.{4}",ROCK,PAPER,SCISSOR,LIZARD,SPOCK));

                string[] choice_names = { ROCK, PAPER, SCISSOR, LIZARD, SPOCK};


                // This will decide how a material wins agains other
                var win = new List<KeyValuePair<String, String>>();
                win.Add(new KeyValuePair<string, string>(ROCK, SCISSOR));
                win.Add(new KeyValuePair<string, string>(ROCK, LIZARD));
                win.Add(new KeyValuePair<string, string>(SCISSOR, PAPER));
                win.Add(new KeyValuePair<string, string>(SCISSOR, LIZARD));
                win.Add(new KeyValuePair<string, string>(PAPER, ROCK));
                win.Add(new KeyValuePair<string, string>(PAPER, SPOCK));
                win.Add(new KeyValuePair<string, string>(LIZARD, SPOCK));
                win.Add(new KeyValuePair<string, string>(LIZARD, PAPER));
                win.Add(new KeyValuePair<string, string>(SPOCK, SCISSOR));
                win.Add(new KeyValuePair<string, string>(SPOCK, ROCK));

                // Computer choice    
                Console.WriteLine("\nComputer's turn");
                Console.WriteLine("----------------------");
                Console.WriteLine("Computer has done secretly. Obviously You're not able to see it now");
                int computer_choice = rand.Next(1, choice_names.Length+1);


                //User choice
                Console.WriteLine("\nYour turn");
                Console.WriteLine("--------------");
                Console.WriteLine("Enter your choice: ");
                int user_choice = Convert.ToInt32(Console.ReadLine());
                while (user_choice > choice_names.Length || user_choice < 1) {
                    Console.WriteLine("enter valid input:");
                    user_choice = Convert.ToInt32(Console.ReadLine());
                }

                var computer_material = choice_names[computer_choice - 1];
                var user_material = choice_names[user_choice - 1];

                Console.WriteLine("\n" + computer_material + " vs " + user_material);

                if (computer_material == user_material)
                    Console.WriteLine("\nDraw");
                else if (MainClass.FindWinner(win,user_material,computer_material))
                    Console.WriteLine(user_material + " wins. You Win");
                else
                    Console.WriteLine(computer_material + " wins. Computer win");

                Console.WriteLine("\nDo you want to continue (Y/N)");
                var answer = Convert.ToString(Console.ReadLine());

                if (answer.ToLower() == "n")
                    break;
        
    
            }

            Console.WriteLine("Thanks for playing");

        }
        }
    }

