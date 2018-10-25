using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeTask3
{
    //class is responsible for the number in the new base system
    //fields are int number,int new base and dictionary, which is for replace digits more 10 to letters

    class NumberConverter
    {
        int number;
        int newBase;
        static Dictionary<int, char> toDigitMore10 = new Dictionary<int, char>
             {
                {10,'A'} , {11,'B'} , {12,'C'},
                {13,'D'} , {14,'E'} , {15,'F'},
                {16,'G'} , {17,'H'} , {18,'I'},
                {19,'J'}
             };
        public NumberConverter(int numb,int baseSys)
        {
            number = numb;
            newBase = baseSys;
        }
        // This method converts a ten-digit number to another base system
        // argument - StringBuilder, which is responsible for the number in the new system and answer
        // return number in new system
        public StringBuilder Converter(StringBuilder numberInNewBase)
        {
             StringBuilder digitInNewBase = new StringBuilder();
             
             bool isInDictionary = false;
             numberInNewBase.AppendFormat("{0} in system on base {1} is ", number, newBase);

             while (number > 0)
             {
                // this cycle is for replace digits more 10 to letters
                 foreach (var digit in toDigitMore10)
                 {
                     if (number % newBase == digit.Key)
                     {
                         isInDictionary = true;
                         digitInNewBase.Append(digit.Value);
                     }
                 }
                 if (isInDictionary == false)
                     digitInNewBase.Append(number % newBase);
                 number = (int)(number / newBase);
                 isInDictionary = false;
             }
          
             char[] answ = (digitInNewBase.ToString()).ToCharArray();
             for (int i = answ.Length - 1; i >= 0; i--)
             {
                 numberInNewBase.Append(answ[i]);
             }
             return numberInNewBase;
        }
    }
}
