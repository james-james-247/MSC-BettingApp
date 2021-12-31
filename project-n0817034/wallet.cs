using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace project_n0817034
{
    public class wallet
    {
        //Current Wallet Amount
        public static double money = 0;

        public static void start()
        {
            StreamReader configFile = new StreamReader("wallet.txt");
            money = Double.Parse(configFile.ReadLine());
            configFile.Close();
        }

        //Adding to wallet when won
        public static void add(double income)
        {
            money += income;
        }

        //minusing wallet when lost
        public static void minus(double outgoing)
        {
            money -= outgoing;
        }

        //Showing the wallet amount
        public static void display()
        {
            Console.WriteLine();
            Console.WriteLine("/ / /  You Have: £" + money.ToString() + " / / /");
        }

        //Adding Money To Game
        public static void addAtm(StreamWriter outputFile)
        {
            Console.WriteLine();
            Console.WriteLine("/ / / How Much Money Would You Like To Add? / / /");

            bool looper = false;
            int adding = 0;
            while (looper == false)
            {
                try
                {
                    adding = Int32.Parse(Console.ReadLine());
                    looper = true;
                }
                catch (Exception)
                {
                    looper = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("/ / / ATM Transfer Stuff Going On! Adding £" + adding + " / / /");
            money += adding;

            Console.WriteLine();
            Console.WriteLine("/ / / Click Enter To Begin / / /");
            Console.ReadLine();

            Program.start(outputFile);
        }

        //Closing the file
        public static void closingFile()
        {
            StreamWriter file = new StreamWriter("wallet.txt");
            file.WriteLine(money);
            file.Close();
        }
    }
}
