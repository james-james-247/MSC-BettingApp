using System;
using System.Collections.Generic;
using System.Text;

namespace project_n0817034
{
    public class race
    {
        public class control 
        {
            public static int lastOdd = 0;
            public static string lastName = "";
            public static int finalOdd = 0;
            
            //Creating dictionary
            public static Dictionary<string, int> raceDict = new Dictionary<string, int>();
        }

        public static int odds(int races, int wins)
        {
            //Getting all values to create odds
            int total = (races * 10) - (wins * 11);
            int finalOdd = 0;
            Random random = new Random();

            //Seperating the values to get different odds
            if (total == races * 10 && total != 0)
            {
                finalOdd = random.Next(8, 10);
            }
            else if (total < races * 10 && total > races * 8)
            {
                finalOdd = random.Next(6, 8);
            }
            else if (total < races * 8 && total > races * 6)
            {
                finalOdd = random.Next(4, 6);
            }
            else if (total < races * 6 && total > races * 4)
            {
                finalOdd = random.Next(2, 4);
            }
            else if (total < races * 4 && total > races * 2)
            {
                finalOdd = random.Next(2, 3);
            }
            else if (total < races)
            {
                finalOdd = random.Next(1, 2);
            }
            else if (total == 0)
            {
                finalOdd = 1;
            }
            return finalOdd;
        }

        public static void calcOdds()
        {
            //Below sections of code claculate odds and sends value to dictionary unless the player gets injured
            int horseOne = odds(players.playerOne.races, players.playerOne.wins);
            if(players.playerOne.checkingInjury() == false)
            {
                race.control.raceDict.Add(players.playerOne.horseName, horseOne);
            }
            
            
            int horseTwo = odds(players.playerTwo.races, players.playerTwo.wins);
            if (players.playerTwo.checkingInjury() == false)
            {
                 race.control.raceDict.Add(players.playerTwo.horseName, horseTwo);
            }


            int horseThree = odds(players.playerThree.races, players.playerThree.wins);
            if (players.playerThree.checkingInjury() == false)
            {
                race.control.raceDict.Add(players.playerThree.horseName, horseThree);
            }


            int horseFour = odds(players.playerFour.races, players.playerFour.wins);
            if (players.playerFour.checkingInjury() == false)
            {
                race.control.raceDict.Add(players.playerFour.horseName, horseFour);
            }


            int horseFive = odds(players.playerFive.races, players.playerFive.wins);
            if (players.playerFive.checkingInjury() == false)
            {
                race.control.raceDict.Add(players.playerFive.horseName, horseFive);
            }
            Console.WriteLine();


            //Displaying the odds calcualted
            Console.WriteLine("/ / / " + players.playerOne.horseName + " Has The Odds " + horseOne + "/1  / / /");
            Console.WriteLine("/ / / " + players.playerTwo.horseName + " Has The Odds " + horseTwo + "/1  / / /");
            Console.WriteLine("/ / / " + players.playerThree.horseName + " Has The Odds " + horseThree + "/1  / / /");
            Console.WriteLine("/ / / " + players.playerFour.horseName + " Has The Odds " + horseFour + "/1  / / /");
            Console.WriteLine("/ / / " + players.playerFive.horseName + " Has The Odds " + horseFive + "/1  / / /");

            racing();
            attributes.addingRisk();
        }

        public static void racing()
        {
            int weight = 0;

            //Here for every value off odds generating a random number the biggest one wins
            foreach(KeyValuePair<string, int> val in race.control.raceDict)
            {
                int value = val.Value;
                string name = val.Key;

                if (value >= 8)
                {
                    weight = new Random().Next(10, 70);
                }
                else if (value >= 5 && val.Value < 8)
                {
                    weight = new Random().Next(20, 80);
                }
                else if (value >= 3 && val.Value < 5)
                {
                    weight = new Random().Next(30, 90);
                }
                else if (value >= 1 && val.Value < 3)
                {
                    weight = new Random().Next(50, 100);
                }
               
                //Heres where the largest number is the winner and stored in the class above
                if(weight > race.control.lastOdd)
                {
                    race.control.lastOdd = weight;
                    race.control.lastName = name;
                    race.control.finalOdd = val.Value;
                }
            }
            //Clearing the dictionary to prevent errors
            race.control.raceDict.Clear();
        }
    }
}

