using System;
using System.Collections.Generic;

namespace PalindromeChecker
{

  class Palindrome
  {
    private char[]  _userArray;

    public char[] GetUserArray()
    {
      return _userArray;
    }

    public void GetUserInput()
    {
      Console.WriteLine("enter a word");
      string userInput = Console.ReadLine();
      // _userArray = userInput.ToCharArray();
      // Console.WriteLine(_userArray[1]);
    }

    public Array<char> FirstArray()
    {
      List<char> originalList = new List<char>();
      foreach (char letter in _userArray)
      {
        originalList.Add(letter);
      }
      originalList.ToString();
      Console.WriteLine(originalList);
      return originalList;
    }
    // public List<char>  SecondArray()
    // {
    //   List<char> reversedList = new List<char>();
    //   Array.Reverse(_userArray);
    //   foreach (char letter in _userArray)
    //   {
    //     reversedList.Add(letter);
    //   }
    //   reversedList.ToString();
    //   Console.WriteLine(reversedList);
    //   return reversedList;
    // }

    public bool PalindromeCheck()
    {
      // Console.WriteLine("{0} is the first letter of the first array", );
      // Console.WriteLine("{0} is the first letter of the second array", );
      if(SecondArray() == FirstArray())
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  class Program
  {
    public static void Main()
    {
      Palindrome newPalindrome = new Palindrome();
      newPalindrome.GetUserInput();
      if(newPalindrome.PalindromeCheck())
      {
        Console.WriteLine("{0} is a palindrome!", newPalindrome.GetUserArray());
      }
      else
      {
        Console.WriteLine("{0} is NOT a palindrome!", newPalindrome.GetUserArray());
      }

    }
  }

}
