/* Author: @eduherminio
 * Related blog post: https://eduherminio.github.io/blog/rock-paper-scissors/
 * Original source code: https://github.com/eduherminio/eduherminio.github.io/blob/master/code/2020-07-07-rock-paper-scissors/InteractiveRockPaperScissors/Program.cs
 */

using System;
using System.Linq;

public static class Program
{
    private enum Item { Rock, Paper, Scissors }

    private static readonly string[] ItemArray = Enum.GetNames(typeof(Item));
    private static readonly Random Rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine($"Let's play! Type '{string.Join("', '", ItemArray[..^1])}' or '{ItemArray.Last()}'");

            if (!Enum.TryParse(typeof(Item), Console.ReadLine().Trim('\''), ignoreCase: true, out var humanInput))
            {
                Console.WriteLine("\tComputer says \"no\": invalid input\n");
                continue;
            }

            var computerInput = Enum.Parse(typeof(Item), ItemArray[Rnd.Next(0, ItemArray.Length)]);
            Console.WriteLine($"\tYou've chosen {humanInput}\n\tComputer has chosen {computerInput}");

            var result = CalculateWinner((int)humanInput, (int)computerInput);

            PrintResultMessage((int)humanInput, result);
        }
    }

    private static int CalculateWinner(int player1, int player2)
    {
        return (Math.Abs(player1 - player2) % 2)
            switch
        {
            0 => player1 == player2
                ? -1
                : new[] { player1, player2 }.Min(),
            1 => new[] { player1, player2 }.Max(),
            _ => throw new Exception(@"¯\_(ツ)_/¯")
        };
    }

    private static void PrintResultMessage(int humanInput, int result)
    {
        var resultMessage = result == -1
            ? "It's a draw!"
            : (result == humanInput) ? "You win!" : "You lose!";

        Console.WriteLine($"\t{resultMessage}\n");
    }
}
