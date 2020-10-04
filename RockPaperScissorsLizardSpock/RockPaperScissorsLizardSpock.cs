using System;
using System.Linq;

namespace RockPaperScissorsLizardSpock
{
	class Program
    {
		private static String[] options = { "rock", "paper", "scissors", "lizard", "spock"};
		
		public static void Main(string[] args)
        {
			String userSelection = "";
			
			// Keep asking for user input until it can be matched to one of the options in the array
			while (!options.Contains(userSelection))
			{
				Console.WriteLine("Enter selection from 'rock', 'paper', 'scissors', 'lizard', 'spock'");
				userSelection = Console.ReadLine().ToLower();
			}
			
			ProcessSelection(userSelection);
		}
		
		private static void ProcessSelection(String userSelection)
		{
			// Select a random number between 0 and 4 (options array indeces)
			Random rnd = new Random();
			int computerSelection = rnd.Next(5);
			
			int userSelectionInt = Array.IndexOf(options, userSelection);
			
			bool computerWins = false;
			bool userWins = false;

			Console.WriteLine("Computer choice is " + options[computerSelection]);
			
			computerWins = CheckWinner(computerSelection, userSelectionInt);
			if (!computerWins)
				userWins = CheckWinner(userSelectionInt, computerSelection);
			
			// Print the results of the game
			if(computerWins)
			{
				Console.WriteLine(options[computerSelection] + " beats " + userSelection + " so computer wins");
			}
			else if (userWins)
			{
				Console.WriteLine(userSelection + " beats " + options[computerSelection] + " so user wins");
			}
			else
			{
				Console.WriteLine("The result was a draw");
			}
		}
		
		private static bool CheckWinner(int checking, int comparing)
		{
			// Use games rules to compare checking selection to comparing selection
			// The ints here correspond to options array indeces
			bool checkingHasWon = false;
			
			switch(checking)
			{
				case 0:
					if(comparing == 2 || comparing == 3)
						checkingHasWon = true;
					break;
				case 1:
					if(comparing == 0 || comparing == 4)
						checkingHasWon = true;
					break;
				case 2:
					if(comparing == 1 || comparing == 3)
						checkingHasWon = true;
					break;
				case 3:
					if(comparing == 1 || comparing == 4)
						checkingHasWon = true;
					break;
				case 4:
					if(comparing == 0 || comparing == 2)
						checkingHasWon = true;
					break;
			}
			
			return checkingHasWon;
		}
	}
}
