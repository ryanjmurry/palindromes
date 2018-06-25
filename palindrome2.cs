using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    //grabbing user input and creating an array of characters
    Console.WriteLine("Enter word: ");
    string userInput = Console.ReadLine();
    char[] userArray = userInput.ToCharArray();

    //reversing array
    Array.Reverse(userArray);

    //turn reverse array back to a string
    string reverseInput = new string(userArray);

    if (userInput == reverseInput)
    {
      Console.WriteLine("Palindrome!");
    }
    else
    {
      Console.WriteLine("Nope!");
    }

  }
}
