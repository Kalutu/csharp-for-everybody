using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("The number of words");

        Console.WriteLine("\nPlease enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.ToLower().Split(' ');
        int numberOfWords = words.Length;

        Console.WriteLine($"\nThere are {numberOfWords} words in the sentence.");
    }