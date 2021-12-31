using System;
using System.Collections.Generic;
using System.IO;

namespace project_n0817034
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/ / / Click Enter To Begin Or 'o' To See Last Sessions Results / / /");
            string open = Console.ReadLine();

            if(open.ToLower() == "o")
            {
                openFile();
            }

            StreamWriter outputFile = new StreamWriter("results.txt");

            //Loading Saved files
            players.playerOne.start();
            players.playerTwo.start();
            players.playerThree.start();
            players.playerFour.start();
            players.playerFive.start();
            wallet.start();

            start(outputFile);
        }

        public static void start(StreamWriter outputFile)
        {
            if (wallet.money == 0)
            {
                Console.WriteLine("/ / / You've Got No Money! Type 'a' To Add More Money! Or Enter To Quit / / /");
                string action = Console.ReadLine();

                if(action.ToLower() == "a")
                {
                    wallet.addAtm(outputFile);
                }
                else
                {
                    closing(outputFile);
                }
            }
            else
            {
                Console.Clear();

                race.calcOdds();
                wallet.display();

                bool looper = false;
                string chosenHorse = "";
                while (looper == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("/ / / Which Horse Would You Like To Bet On? / / /");
                    chosenHorse = Console.ReadLine().Trim();

                    if (chosenHorse.ToLower() == players.playerOne.horseName.ToLower()
                        || chosenHorse.ToLower() == players.playerTwo.horseName.ToLower()
                        || chosenHorse.ToLower() == players.playerThree.horseName.ToLower()
                        || chosenHorse.ToLower() == players.playerFour.horseName.ToLower()
                        || chosenHorse.ToLower() == players.playerFive.horseName.ToLower())
                    {
                        looper = true;
                    }
                }

                bool looperTwo = false;
                int betAmount = 0;
                while (looperTwo == false)
                {
                    bool internalLoop = false;
                    while (internalLoop == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("/ / / How Much Would You Like To Bet? / / /");
                        try
                        {
                            betAmount = Int32.Parse(Console.ReadLine());
                            internalLoop = true;
                        }
                        catch (Exception)
                        {
                            internalLoop = false;
                            Console.WriteLine();
                            Console.WriteLine("/ / / Only Numbers (Whole No Decimal Place) Allowed / / /");
                        }
                    }

                    if (betAmount > wallet.money)
                    {
                        Console.WriteLine("/ / / You Don't Have That Much Money / / /");
                        looperTwo = false;
                    }
                    else
                    {
                        looperTwo = true;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("/ / / The Wining Horse is: " + race.control.lastName + " / / /");
                outputFile.WriteLine(race.control.lastName + " wins the race, with the odds " + race.control.finalOdd + "/1");

                if (race.control.lastName.ToLower() == chosenHorse.ToLower())
                {
                    int income = betAmount * race.control.finalOdd;
                    wallet.add(income);
                }
                else
                {
                    wallet.minus(betAmount);
                }

                players.addingToWins(race.control.lastName.ToLower());

                race.control.lastOdd = 0;
                race.control.lastName = "";
                race.control.finalOdd = 0;


                Console.WriteLine();
                Console.WriteLine("/ / / Click Enter To Begin Or Type 'c' To End / / /");
                string closer = Console.ReadLine();

                if (closer.ToLower() == "c")
                {
                    closing(outputFile);
                }

                start(outputFile);
            }
        }

        public static void closing(StreamWriter outputFile)
        {
            outputFile.WriteLine("Player Ended With £" + wallet.money);
            outputFile.Close();

            players.playerOne.closingFile();
            players.playerTwo.closingFile();
            players.playerThree.closingFile();
            players.playerFour.closingFile();
            players.playerFive.closingFile();
            wallet.closingFile();

            Environment.Exit(0);
        }

        public static void openFile()
        {
            Console.WriteLine();

            string[] fileText = File.ReadAllLines("results.txt");
            foreach(string line in fileText)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("/ / / Click Enter To Begin / / /");
            Console.ReadLine();

            StreamWriter outputFile = new StreamWriter("results.txt");
            start(outputFile);
        }
    }
}
