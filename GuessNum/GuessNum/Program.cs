using System;
using System.Threading;
namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)
        {
        playAgain:
        retry:
            int numLevel = 0;
            int startNum = 0;
            bool success = false;
            
            Console.WriteLine("<>=<>=<>=<>=<>=<>=<>WELCOME TO GUESS NUM!<>=<>=<>=<>=<>=<>=<>");
            delay();
            Console.WriteLine("Choose level (1,2,3) or custom.");
            string level = Console.ReadLine();
            delay();
            
           
            int CountLevelGranted = 0;
            int attemps = 0;
            
            if (level == "1")
            {
                numLevel = 10;
                CountLevelGranted = 3;
            }
            else if (level == "2")
            {
                numLevel = 20;
                CountLevelGranted = 6;
            }
            else if (level == "3")
            {
                numLevel = 30;
                CountLevelGranted = 9;
            }
            else if (level == "custom")
            {
                delay();
                Console.WriteLine("Choose starting num.");
                startNum = int.Parse(Console.ReadLine());
                delay();
                Console.WriteLine("Choose final num.");
                numLevel = int.Parse(Console.ReadLine());
                delay();
                Console.WriteLine("Choose attempts - num.");
                CountLevelGranted = int.Parse(Console.ReadLine());
            }
            Random GeneratedNum = new Random();
            int numGen = GeneratedNum.Next(startNum, numLevel);
            if (level == "1" || level == "2" || level == "3" || level == "custom")
            {
                Console.WriteLine("Level " + level + ":");
                while (!success)
                {
                    int atemptsRemaining = CountLevelGranted - attemps - 1;
                    Console.WriteLine("Guess the number {0},{1}", startNum, numLevel);






                    int num = int.Parse(Console.ReadLine());

                    if (numGen > num)
                    {
                        Console.WriteLine("Higher!");
                        Console.WriteLine("Attempts remaining: " + atemptsRemaining);

                    }
                    else if (numGen < num)
                    {
                        Console.WriteLine("Lower!");
                        Console.WriteLine("Attempts remaining: " + atemptsRemaining);
                    }
                    if (numGen == num)
                    {
                        Console.WriteLine("You guessed the right number!");

                        success = true;
                        Console.WriteLine("Play again?");
                        string playAgain = Console.ReadLine();
                        if (playAgain == "Y" || playAgain == "y" || playAgain == "yes" || playAgain == "YES" || playAgain == "Yes")
                        {
                            goto playAgain;
                        }
                        else
                        {

                            break;
                        }

                    }
                    else
                    {
                        
                        attemps++;
                    }
                    if (attemps == CountLevelGranted)
                    {
                        break;
                    }

                }
                delay();
                if (!success)
                {
                    Console.WriteLine("<>=<>=<>=<>=<>=<>=<>=<>YOU FAILED!<>=<>=<>=<>=<>=<>=<>=<>");
                    Console.WriteLine("Retry?");
                    string retry = Console.ReadLine();
                    if (retry == "Y" || retry == "y" || retry == "yes" || retry == "YES" || retry == "Yes")
                    {
                        goto retry;
                    }
                }
                else
                {
                    Console.WriteLine("<>=<>=<>=<>=<> CONGRATULATIONS YOU BEAT GUESS NUM! <>=<>=<>=<>=<>=<>");
                }
            }
            else
            {
                Console.WriteLine("invalid");
            }
            
            


        }
        static void delay()
        {
            Thread.Sleep(500);
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine();
        }
    }
}
