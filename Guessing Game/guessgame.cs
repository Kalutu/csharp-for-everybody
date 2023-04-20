using System;

class Program {
  static void Main(string[] args) {
    Random random = new Random();
    int secretNumber = random.Next(1, 101);
    int guess = 0;
    int numberOfGuesses = 0;

    Console.WriteLine("Guess the secret number between 1 and 100.");

    while (guess != secretNumber) {
      Console.Write("Enter your guess: ");
      guess = Convert.ToInt32(Console.ReadLine());

      if (guess < secretNumber) {
        Console.WriteLine("Your guess is too low. Try again.");
      } else if (guess > secretNumber) {
        Console.WriteLine("Your guess is too high. Try again.");
      }

      numberOfGuesses++;
    }

    Console.WriteLine("Congratulations! You guessed the secret number in {0} tries.", numberOfGuesses);
    Console.ReadKey();
  }
}
