using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.WriteLine("Enter your move (rock, paper, or scissors): ");
            string playerMove = Console.ReadLine().ToLower();

            // generate a random move for the computer
            Random rand = new Random();
            string[] moves = { "rock", "paper", "scissors" };
            string computerMove = moves[rand.Next(3)];

            Console.WriteLine("Computer played " + computerMove);

            // determine the winner
            if (playerMove == computerMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerMove == "rock" && computerMove == "scissors" ||
                     playerMove == "paper" && computerMove == "rock" ||
                     playerMove == "scissors" && computerMove == "paper")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }

            Console.ReadLine();
        }
    }
}
