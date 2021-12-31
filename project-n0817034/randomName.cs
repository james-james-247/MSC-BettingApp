using System;
using System.Collections.Generic;
using System.Text;

namespace project_n0817034
{
    class randomName
    {
        //This Class Adds A New Competitor When One Gets Injured
        public static string newCompetitor()
        {
            int length = new Random().Next(4, 7);

            Random random = new Random();
            //Consonants Plus Some Special Specific Sounds Like sh and zh 
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            //Vowels Plus y 
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            string compName = "";

            //This Gets The First Two Letters of The New Name
            compName += consonants[random.Next(consonants.Length)].ToUpper();
            compName += vowels[random.Next(vowels.Length)];

            //This ensures the systems knows weve already added two letters
            int started = 2;

            //length is Provided and Is Random
            while (started < length)
            {
                compName += consonants[random.Next(consonants.Length)];
                started++;
                compName += vowels[random.Next(vowels.Length)];
                started++;
            }

            return compName;
        }
    }
}
