using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbersintowords2
{
    class Class1
    {

        int Numbersintowords2;
        public static string Numbersintowords2(int number)
        {
            if (number == 0) return "zero";

            if (number < 0) return "minus" + Numbersintowords2(Math.Abs(number));

            string words = "";

            if((number / 1000000) > 0)
            {
                words += Numbersintowords2(number / 1000000) + "million";
                number %= 1000000;
            }

            if((number/ 1000) > 0)
            {
                words += Numbersintowords2(number / 1000) + "thousand";
                number %= 1000;
            }
        }   

            if((Numbersintowords2 / 100) > 0)
            words
    }
}
