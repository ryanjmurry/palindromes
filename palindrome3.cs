using System;
using System.Collections.Generic;

class Program
{
  public static bool PalindromeChecker(string userWord)
  {
    int y = (userWord.Length -1);
    int x = 0;
    while(true)
    {
      if(x > y)
      {
        return true;
      }
      if(userWord[x] != userWord[y])
      {
        return false;
      }
      y--;
      x++;
    }
  }

  public static void Main()
  {
    Console.WriteLine("Enter a word");
    string userInput = Console.ReadLine();
    Console.WriteLine(userInput);
    if(PalindromeChecker(userInput))
    {
      Console.WriteLine("Palindrome!");
    }
    else
    {
      Console.WriteLine("not a palindrome");
    }



  }
}
