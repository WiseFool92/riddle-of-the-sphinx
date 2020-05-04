using System;
using System.Collections.Generic;

class Riddle
{
  // static int count = 1;
  static int[] asked = { 0, 0, 0 };
  static void Main()
  {
    Console.WriteLine("Welcome to the desert. I am the Sphinx. Answer my 3 riddles to access my treasure. Guess wrong and perish");


    AskRiddle();

  }

  static void AskRiddle()
  {
    Dictionary<int, string> riddleDictionary = new Dictionary<int, string>() { { 1, "What 4-letter word can be written forward, backward or upside down, and can still be read from left to right?" },
    {2, "What can be caught but never thrown?"}, {3, "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?" } };

    Random rand = new Random();
    int count = rand.Next(1, 4);


    if (count == 1 && asked[0] == 0)
    {
      Console.WriteLine(riddleDictionary[count]);
      string userAnswer = Console.ReadLine();
      string answer = RiddleAnswer(count);
      asked[0] = count;
      Console.WriteLine(count);
      Console.WriteLine(asked[0]);
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
      Console.WriteLine(riddleDictionary[count]);
      string userAnswer = Console.ReadLine();
      string answer = RiddleAnswer(count);
      asked[1] = count;
      Console.WriteLine(count);
      Console.WriteLine(asked[1]);
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
      Console.WriteLine(riddleDictionary[count]);
      string userAnswer = Console.ReadLine();
      string answer = RiddleAnswer(count);
      asked[2] = count;
      Console.WriteLine(count);
      Console.WriteLine(asked[2]);
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

  static string RiddleAnswer(int num)
  {
    Dictionary<int, string> answerDictionary = new Dictionary<int, string>() { { 1, "NOON" }, { 2, "a cold" }, { 3, "fire" } };

    string ans = answerDictionary[num];

    Console.WriteLine("Correct");
    return (ans);

  }

}