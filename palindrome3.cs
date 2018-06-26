using System;
using System.Collections.Generic;

class Palindrome
{
    private string _userInput;
    private int _max;
    private int _min = 0;

    public bool PalindromeChecker()
    {
        Console.WriteLine("Enter a word: ");
        _userInput = Console.ReadLine();
        _max = _userInput.Length - 1;

        while(true)
        {
          if(_min > _max)
          {
            return true;
          }
          if(_userInput[_min] != _userInput[_max])
          {
            return false;
          }
          _max--;
          _min++;
        }
    }
}

class Program
{
    public static void Main()
    {
        Palindrome userPalindrome = new Palindrome();
        if (userPalindrome.PalindromeChecker())
        {
            Console.WriteLine("Palindrome!");
        }
        else
        {
            Console.WriteLine("Nope!");
        }
    }
}
