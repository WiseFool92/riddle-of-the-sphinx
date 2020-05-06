using System;
using System.Collections.Generic;
using Sphinx.Riddles;

namespace Riddles
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the desert. I am the Sphinx. Answer my 3 riddles to access my treasure. Guess wrong and perish");

      Riddle.AskRiddle();

    }
  }
}