using System;
using System.Collections.Generic;

namespace Sphinx.Riddles
{
  public class Riddle
  {
    // static int count = 1;
    public static int[] asked = { 0, 0, 0 };
  
    private static Dictionary<int, string> _riddleDictionary = new Dictionary<int, string>() { { 1, "What 4-letter word can be written forward, backward or upside down, and can still be read from left to right?" },
    {2, "What can be caught but never thrown?"}, {3, "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?" } };

    // public static Dictionary<int, string> GetRiddleDictionary()
    // {
    //   return _riddleDictionary;
    // }
   
    private static Dictionary<int, string> _answerDictionary = new Dictionary<int, string>() { { 1, "NOON" }, { 2, "a cold" }, { 3, "fire" } };

    public static void AskRiddle()
    {

      Random rand = new Random();
      int count = rand.Next(1, 4);


      if (count == 1 && asked[0] == 0)
      {
        Console.WriteLine(_riddleDictionary[count]);
        string userAnswer = Console.ReadLine();
        string answer = RiddleAnswer(count);
        asked[0] = count;
    
        if (userAnswer == answer)
        {
          // count += 1;
          AskRiddle();
        }
        else
        {
          Console.WriteLine("Incorrect. You died");
        }
      }
      else if (count == 2 && asked[1] == 0)
      {
        Console.WriteLine(_riddleDictionary[count]);
        string userAnswer = Console.ReadLine();
        string answer = RiddleAnswer(count);
        asked[1] = count;
        
        if (userAnswer == answer)
        {

          AskRiddle();
        }
        else
        {
          Console.WriteLine("Incorrect. You died");
        }
      }
      else if (count == 3 && asked[2] == 0)
      {
        Console.WriteLine(_riddleDictionary[count]);
        string userAnswer = Console.ReadLine();
        string answer = RiddleAnswer(count);
        asked[2] = count;
      
        if (userAnswer == answer)
        {
          AskRiddle();
        }
        else
        {
          Console.WriteLine("You've made it far but incorrect. You died");
        }
      }
      else if (asked[0] != 0 && asked[1] != 0 && asked[2] != 0)
      {
        Console.WriteLine("Here's my treasure");
      }
      else
      {
        AskRiddle();
      }
    }

    public static string RiddleAnswer(int num)
    {

      string ans = _answerDictionary[num];

      Console.WriteLine("Correct");
      return (ans);

    }

  }
}