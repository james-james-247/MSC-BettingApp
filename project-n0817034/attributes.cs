using System;
using System.Collections.Generic;
using System.Text;

namespace project_n0817034
{
    public class attributes
    {
        //Setup risk
        public static int risk = 0;

        public static void addingRisk()
        {
            //Adding one to risk
            risk += 1;
            //if its over 10 reset it
            if (risk > 10)
            {
                risk = 0;
            }
        }
    }
}
