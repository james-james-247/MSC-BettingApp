using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace project_n0817034
{
    class players
    {
        //Player One
        public class playerOne
        {
            public static string horseName = "";
            public static int wins = 0;
            public static int races = 0;

            public static void start()
            {
                StreamReader configFile = new StreamReader("playerOne.txt");
                horseName = configFile.ReadLine();
                wins = Int32.Parse(configFile.ReadLine());
                races = Int32.Parse(configFile.ReadLine());
                configFile.Close();
            }

            public static void changing(bool win)
            {
                //Adding one to the win counter if they win
                if(win == true)
                {
                    wins += 1;
                }

                //Adding one to the race counter
                races += 1;
            }

            public static void newName(string name)
            {
                //This is when a horse is replaced with a new one
                horseName = name;
                wins = 0;
                races = 0;
            }

            public static bool checkingInjury()
            {
                int risk = attributes.risk;

                Random random = new Random();
                int ran = random.Next(0, 20) + risk + races;
                int ranTwo = random.Next(20, 50);
                if (ran > ranTwo)
                {
                    string name = randomName.newCompetitor();
                    Console.WriteLine("/ / / "  + horseName + " Was Injured, New Horse " + name + " Was Added / / /");
                    playerOne.newName(name);

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void closingFile()
            {
                StreamWriter file = new StreamWriter("playerOne.txt");
                file.WriteLine(horseName);
                file.WriteLine(wins);
                file.WriteLine(races);
                file.Close();
            }
        }

        //Player Two
        public class playerTwo
        {
            public static string horseName = "";
            public static int wins = 0;
            public static int races = 0;

            public static void start()
            {
                StreamReader configFile = new StreamReader("playerTwo.txt");
                horseName = configFile.ReadLine();
                wins = Int32.Parse(configFile.ReadLine());
                races = Int32.Parse(configFile.ReadLine());
                configFile.Close();
            }

            public static void changing(bool win)
            {
                //Adding one to the win counter if they win
                if (win == true)
                {
                    wins += 1;
                }

                //Adding one to the race counter
                races += 1;
            }

            public static void newName(string name)
            {
                //This is when a horse is replaced with a new one
                horseName = name;
                wins = 0;
                races = 0;
            }

            public static bool checkingInjury()
            {
                int risk = attributes.risk;

                Random random = new Random();
                int ran = random.Next(0, 20) + risk + races;
                int ranTwo = random.Next(20, 50);
                if (ran > ranTwo)
                {
                    string name = randomName.newCompetitor();
                    Console.WriteLine("/ / / " + horseName + " Was Injured, New Horse " + name + " Was Added / / /");
                    playerTwo.newName(name);

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void closingFile()
            {
                StreamWriter file = new StreamWriter("playerTwo.txt");
                file.WriteLine(horseName);
                file.WriteLine(wins);
                file.WriteLine(races);
                file.Close();
            }
        }

        //Player Three
        public class playerThree
        {
            public static string horseName = "";
            public static int wins = 0;
            public static int races = 0;

            public static void start()
            {
                StreamReader configFile = new StreamReader("playerThree.txt");
                horseName = configFile.ReadLine();
                wins = Int32.Parse(configFile.ReadLine());
                races = Int32.Parse(configFile.ReadLine());
                configFile.Close();
            }

            public static void changing(bool win)
            {
                //Adding one to the win counter if they win
                if (win == true)
                {
                    wins += 1;
                }

                //Adding one to the race counter
                races += 1;
            }

            public static void newName(string name)
            {
                //This is when a horse is replaced with a new one
                horseName = name;
                wins = 0;
                races = 0;
            }

            public static bool checkingInjury()
            {
                int risk = attributes.risk;

                Random random = new Random();
                int ran = random.Next(0, 20) + risk + races;
                int ranTwo = random.Next(20, 50);
                if (ran > ranTwo)
                {
                    string name = randomName.newCompetitor();
                    Console.WriteLine("/ / / " + horseName + " Was Injured, New Horse " + name + " Was Added / / /");
                    playerThree.newName(name);

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void closingFile()
            {
                StreamWriter file = new StreamWriter("playerThree.txt");
                file.WriteLine(horseName);
                file.WriteLine(wins);
                file.WriteLine(races);
                file.Close();
            }
        }

        //Player Four
        public class playerFour
        {
            public static string horseName = "";
            public static int wins = 0;
            public static int races = 0;

            public static void start()
            {
                StreamReader configFile = new StreamReader("playerFour.txt");
                horseName = configFile.ReadLine();
                wins = Int32.Parse(configFile.ReadLine());
                races = Int32.Parse(configFile.ReadLine());
                configFile.Close();
            }

            public static void changing(bool win)
            {
                //Adding one to the win counter if they win
                if (win == true)
                {
                    wins += 1;
                }

                //Adding one to the race counter
                races += 1;
            }

            public static void newName(string name)
            {
                //This is when a horse is replaced with a new one
                horseName = name;
                wins = 0;
                races = 0;
            }

            public static bool checkingInjury()
            {
                int risk = attributes.risk;

                Random random = new Random();
                int ran = random.Next(0, 20) + risk + races;
                int ranTwo = random.Next(20, 50);
                if (ran > ranTwo)
                {
                    string name = randomName.newCompetitor();
                    Console.WriteLine("/ / / " + horseName + " Was Injured, New Horse " + name + " Was Added / / /");
                    playerFour.newName(name);
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void closingFile()
            {
                StreamWriter file = new StreamWriter("playerFour.txt");
                file.WriteLine(horseName);
                file.WriteLine(wins);
                file.WriteLine(races);
                file.Close();
            }
        }

        //Player Five
        public class playerFive
        {
            public static string horseName = "";
            public static int wins = 0;
            public static int races = 0;

            public static void start()
            {
                StreamReader configFile = new StreamReader("playerFive.txt");
                horseName = configFile.ReadLine();
                wins = Int32.Parse(configFile.ReadLine());
                races = Int32.Parse(configFile.ReadLine());
                configFile.Close();
            }

            public static void changing(bool win)
            {
                //Adding one to the win counter if they win
                if (win == true)
                {
                    wins += 1;
                }

                //Adding one to the race counter
                races += 1;
            }

            public static void newName(string name)
            {
                //This is when a horse is replaced with a new one
                horseName = name;
                wins = 0;
                races = 0;
            }

            public static bool checkingInjury()
            {
                int risk = attributes.risk;

                Random random = new Random();
                int ran = random.Next(0, 20) + risk + races;
                int ranTwo = random.Next(20, 50);
                if (ran > ranTwo)
                {
                    string name = randomName.newCompetitor();
                    Console.WriteLine("/ / / " + horseName + " Was Injured, New Horse " + name + " Was Added / / /");
                    playerFive.newName(name);

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void closingFile()
            {
                StreamWriter file = new StreamWriter("playerFive.txt");
                file.WriteLine(horseName);
                file.WriteLine(wins);
                file.WriteLine(races);
                file.Close();
            }
        }


        //Here we send to functions above depending on who won
        public static void addingToWins(string winner)
        {
            if(winner == playerOne.horseName.ToLower())
            {
                playerOne.changing(true);

                playerTwo.changing(false);
                playerThree.changing(false);
                playerFour.changing(false);
                playerFive.changing(false);
            }
            else if(winner == playerTwo.horseName.ToLower())
            {
                playerTwo.changing(true);

                playerOne.changing(false);
                playerThree.changing(false);
                playerFour.changing(false);
                playerFive.changing(false);
            }
            else if(winner == playerThree.horseName.ToLower())
            {
                playerThree.changing(true);

                playerOne.changing(false);
                playerTwo.changing(false);
                playerFour.changing(false);
                playerFive.changing(false);
            }
            else if(winner == playerFour.horseName.ToLower())
            {
                playerFour.changing(true);

                playerOne.changing(false);
                playerTwo.changing(false);
                playerThree.changing(false);
                playerFive.changing(false);
            }
            else if(winner == playerFive.horseName.ToLower())
            {
                playerFive.changing(true);

                playerOne.changing(false);
                playerTwo.changing(false);
                playerThree.changing(false);
                playerFour.changing(false);
            }
        }
    }
}
