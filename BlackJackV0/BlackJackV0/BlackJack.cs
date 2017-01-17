using System;
using Veikkaus;
/// <summary>
/// A simple example of Blackjack card game
/// Last modified by Anton Telegey 17.1.2017
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
    static void Main()
    {
      Lotto.DrawLotto();
      //Muutettu();
    }
    static void Muutettu()
    {
      Random rng = new Random();
      int theirNumber;
      System.Console.WriteLine("*** BlackJack! ***");
      do
      {
        System.Console.Write("Can you beat my number? Enter any number between 1-21: ");

        string line = System.Console.ReadLine();

        if (line == "X" || line == "exit")
        {
          break;
        }

        //comparing that given umber is valid
        
        if (int.TryParse(line, out theirNumber) && !(theirNumber < 1 || theirNumber > 21))
        {
          int myNumber = rng.Next(10, 22);
          //comparing
          if (theirNumber >= myNumber && theirNumber <= 21)
          {
            System.Console.WriteLine("You win. My number was {0}", myNumber);
          }
          else
          {
            System.Console.WriteLine("You lose. My number was {0}", myNumber);
          }
        }
        else
        {
          Console.WriteLine("The given number is out of limits, try again.");
        }
      } while (true);
    }
 

  static void Alkuperainen()
    {
      int myNumber = 17;
      int theirNumber;
      System.Console.WriteLine("*** BlackJack! ***");
      System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
      //reading and converting 
      theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
      //comparing that given umber is valid
      if (theirNumber < 1 || theirNumber > 21)
      {
        Console.WriteLine("The given number is out of limits, try again.");
      }
      else {
        //comparing
        if (theirNumber >= myNumber && theirNumber <= 21)
        {
          System.Console.WriteLine("You win.");
        }
        else {
          System.Console.WriteLine("You lose.");
        }
      }
    }
  }
}