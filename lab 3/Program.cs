using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        string reversedWord = ReverseWord(word);
        if (word == reversedWord)
        {
            Console.WriteLine("The word is a palindrome.");
        }
        else
        {
            Console.WriteLine("The word is not a palindrome.");
        }
    }

    static string ReverseWord(string word)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in word)
        {
            stack.Push(c);
        }

        string reversedWord = "";
        while (stack.Count > 0)
        {
            reversedWord += stack.Pop();
        }

        return reversedWord;
    }
}