using System;

class HangmanGame
{
    private string wordToGuess;
    private char[] guessedLetters;
    private int maxGuesses;
    private int incorrectGuesses;

    public HangmanGame(string word)
    {
        wordToGuess = word.ToUpper();
        guessedLetters = new char[wordToGuess.Length];
        maxGuesses = 6; // Maximum allowed incorrect guesses
        incorrectGuesses = 0;
    }

    public void Play()
    {
        Console.WriteLine("Welcome to Hangman!");

        while (true)
        {
            Console.WriteLine();
            DisplayGuessedLetters();
            Console.WriteLine();

            Console.Write("Enter a letter: ");
            char letter = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (char.IsLetter(letter))
            {
                if (!IsLetterGuessed(letter))
                {
                    if (wordToGuess.Contains(letter))
                    {
                        UpdateGuessedLetters(letter);

                        if (IsWordGuessed())
                        {
                            Console.WriteLine("Congratulations! You guessed the word: " + wordToGuess);
                            break;
                        }
                    }
                    else
                    {
                        incorrectGuesses++;
                        Console.WriteLine("Incorrect guess! You have " + (maxGuesses - incorrectGuesses) + " guesses left.");

                        if (incorrectGuesses == maxGuesses)
                        {
                            Console.WriteLine("Game over! The word was: " + wordToGuess);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You have already guessed that letter. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Enter a single letter.");
            }
        }

        Console.WriteLine("Thank you for playing Hangman!");
    }

    private void DisplayGuessedLetters()
    {
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (guessedLetters[i] != '\0')
            {
                Console.Write(guessedLetters[i] + " ");
            }
            else
            {
                Console.Write("_ ");
            }
        }
    }

    private bool IsLetterGuessed(char letter)
    {
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (guessedLetters[i] == letter)
            {
                return true;
            }
        }

        return false;
    }

    private void UpdateGuessedLetters(char letter)
    {
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (wordToGuess[i] == letter)
            {
                guessedLetters[i] = letter;
            }
        }
    }

    private bool IsWordGuessed()
    {
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (guessedLetters[i] == '\0')
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        HangmanGame game = new HangmanGame("hangman");
        game.Play();
    }
}

