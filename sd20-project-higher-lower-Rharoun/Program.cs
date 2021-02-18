using System;
using System.Threading;
using System.Collections.Generic;

namespace ProjectHigherLower
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Variables

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Age Check                    
            Console.ForegroundColor = ConsoleColor.Green;
            Program.WriteLineSlow("Welcome to Project - The card guessing game.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Before we start, what is your age?");

            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
            {

                Console.WriteLine("Welcome!");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you need to be older than 18 years to continue.");
                Console.ResetColor();
                Environment.Exit(0);
            }

            // Info 
            Console.Clear();
            Console.WriteLine("Please enter a name");
            string Name = Console.ReadLine();
            Program.WriteLineSlow("Your name has been saved as " + Name + ".");

            Console.ResetColor();
            // Rules & Instructions
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Program.WriteLineSlow("How to play Higher lower");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Program.WriteLineSlow("You need to guess if the card is higher or lower.");
            Program.WriteLineSlow("When you start, you have 3 Life Points (LP)");
            Program.WriteLineSlow("When you guess wrong you lose 1 LP.");
            Program.WriteLineSlow("In order to guess right you need to tell if the card is higher or lower than the drawn card");
            Program.WriteLineSlow("Each time you guess right your score goes up with a quarter");
            Program.WriteLineSlow("If your LP goes to 0, then the program will reset and your progress in the current sessiont will be lost. (Not the leaderboard score.)");
            Program.WriteLineSlow("..");
            Program.WriteLineSlow(".");
            Console.ResetColor();

            // start
            Console.ForegroundColor = ConsoleColor.Red;
            Program.WriteLineSlow(" WARNING!!! Do not use capitalized letters!");
            Console.ResetColor();
            Program.WriteLineSlow("The computer is generating the deck of cards...");
            Console.ForegroundColor = ConsoleColor.Green;
            int lives = 3;
            for (int i = 0; lives > 0; i++)
            {
               

                string[] card2 = {  "\u2666", "\u2665", "\u2663", "\u2660" };
                string[] cardValue = Card.GetAllowedCardValues();

                Console.ForegroundColor = ConsoleColor.Yellow;
       

                Random rnd = new Random();
                string[] card3 = { cardValue[rnd.Next(0, 13)], card2[rnd.Next(0, 4)] };
                string[] card4 = { cardValue[rnd.Next(0, 13)], card2[rnd.Next(0, 4)] };

                int cardmake3()
                {
                    int cijfer = 3;
                    int plus = 0;
                    for (int i = 2; i < 15; i++)
                    {
                        if (card3[0] == cardValue[plus])
                        {
                            cijfer = i;
                            plus++;
                        }
                        else
                        {
                            plus++;
                        }

                    }
                    return cijfer;
                }

                int cardmake2()
                {
                    int cijfer = 3;
                    int plus = 0;
                    for (int i = 2; i < 15; i++)
                    {
                        if (card4[0] == cardValue[plus])
                        {
                            cijfer = i;
                            plus++;
                        }
                        else
                        {
                            plus++;
                        }

                    }
                    return cijfer;
                }
                Console.Clear();
                Console.WriteLine("card:  ┌----┐");
                if (cardmake3() >= 10)
                {
                Console.WriteLine("       |" + cardmake3() + "  |");
                }
                else
                {
                Console.WriteLine("       |" + cardmake3() + "   |");
                }
                Console.WriteLine("       | " + card3[1] + "  |");
                Console.WriteLine("       |    | ");
                Console.WriteLine("       |____|     ");
                Console.WriteLine(Name + " choose, h or l (Higher or Lower)");
                string guess = Console.ReadLine();
                if (guess == "h" && cardmake3() < cardmake2())
                {
                    //goed antwoord
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("the card was");
                    Console.WriteLine("card:  ┌----┐");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine("       |" + cardmake2() + "  |");
                    }
                    else
                    {
                        Console.WriteLine("       |" + cardmake2() + "   |");
                    }
                    Console.WriteLine("       | " + card4[1] + "  |");
                    Console.WriteLine("       |    | ");
                    Console.WriteLine("       |____|     ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Program.WriteLineSlow("goed");
               
                    Console.Clear();

                }
                else if (guess == "h" && cardmake3() > cardmake2())
                {
                    //fout antwoord
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("the card was");
                    Console.WriteLine("card:  ┌----┐");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine("       |" + cardmake2() + "  |");
                    }
                    else
                    {
                        Console.WriteLine("       |" + cardmake2() + "   |");
                    }
                    Console.WriteLine("       | " + card4[1] + "  |");
                    Console.WriteLine("       |    | ");
                    Console.WriteLine("       |____|     ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.WriteLineSlow("fout");
   
                    Console.Clear();
                    lives--;
                }
                else if (guess == "l" && cardmake3() > cardmake2())
                {
                    //goed antwoord
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("the card was");
                    Console.WriteLine("card:  ┌----┐");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine("       |" + cardmake2() + "  |");
                    }
                    else
                    {
                        Console.WriteLine("       |" + cardmake2() + "   |");
                    }
                    Console.WriteLine("       | " + card4[1] + "  |");
                    Console.WriteLine("       |    | ");
                    Console.WriteLine("       |____|     ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Program.WriteLineSlow("goed");
    
                    Console.Clear();
                }

                else if (guess == "l" && cardmake3() < cardmake2())
                {
                    //fout antwoord
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("the card was");
                    Console.WriteLine("card:  ┌----┐");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine("        |" + cardmake2() + "  |");
                    }
                    else
                    {
                        Console.WriteLine("        |" + cardmake2() + "   |");
                    }
                    Console.WriteLine("        | " + card4[1] + "  |");
                    Console.WriteLine("        |    | ");
                    Console.WriteLine("        |____|     ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.WriteLineSlow("fout");
  
                    Console.Clear();
                    lives--;
                }
                else if (cardmake3() == cardmake2())
                {
                    // kaart is gelijk
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("the card was");
                    Console.WriteLine("card:  ┌----┐");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine("       |" + cardmake2() + "  |");
                    }
                    else
                    {
                        Console.WriteLine("       |" + cardmake2() + "   |");
                    }
                    Console.WriteLine("       | " + card4[1] + "  |");
                    Console.WriteLine("       |    | ");
                    Console.WriteLine("       |____|     ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Program.WriteLineSlow("gelijk");

                    Console.Clear();
                }
            }
        }
            public static void WriteLineSlow(string message)
            {
                Console.WriteLine(message);
                Thread.Sleep(2000);
            }
        
    }
}
