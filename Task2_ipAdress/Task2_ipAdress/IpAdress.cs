using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ipAdress
{
    class IpAdress
    {
        string ourString;
        string[] splitString;
        List<string> listNearlyIp = new List<string>();
        List<List<string>> allNearlyIp = new List<List<string>>();
        public IpAdress(string str)
        {
            ourString = str;
            splitString = ourString.Split('.');
        }
        
        public List<List<string>> GetIP()
        {
            foreach (string splitStr in splitString)
            {
                int splitStrEnd = splitStr.Length;
                int listNearlyIpCount = listNearlyIp.Count();
                int i = 1;
                if (listNearlyIpCount == 0)
                {
                    if (CheckingFirst(splitStr, splitStrEnd,ref i) == true)
                    {
                        listNearlyIp.Add(splitStr.Substring(splitStrEnd - i));
                    }
                }
                else
                {

                    IfListCountNotEqual0(splitStr,listNearlyIpCount);
                }
                
            }
            return allNearlyIp;
        }

        public bool CheckingToValidVlalue()
        {
            bool check = true;
            foreach (string list in listNearlyIp)
            {
                if (Convert.ToInt32(list) > 255)
                {
                    check = false;
                }
            }
            return check;
        }
        public void IfListCountNotEqual0(string splitStr, int listNearlyIpCount)
        {
            if (listNearlyIpCount == 4)
            {
                IfListCountEqual4(splitStr);
            }
            else
            {
                if (CheckingNotFirstAndNotLast(splitStr) == true)
                {
                    listNearlyIp.Add(splitStr);
                }
            }
        }

        public void IfListCountEqual4(string splitStr)
        {
            if (Char.IsDigit(splitStr[0]) == true)
            {
                listNearlyIp.Clear();
            }
            else
            {
                if (CheckingToValidVlalue() == true)
                {
                    allNearlyIp.Add(listNearlyIp);
                    listNearlyIp.Clear();
                    Console.WriteLine(allNearlyIp.Count());
                }

            }
        }
        public bool CheckingNotFirstAndNotLast(string splitStr)
        {
            bool check = true;
            int k = 0;
            foreach (char symbol in splitStr)
            {
                if (Char.IsDigit(symbol) == false)
                {
                    check = false;
                    break;
                }
                else
                {
                    k++;
                }
            }
            if(k>3 || k == 0 )
            {
                check = false;
            }
            return check;
        }

        public bool CheckingFirst(string splitStr, int splitStrLength, ref int i)
        {
            bool check = true;
            for (; i < 4; i++)
            {
                if (Char.IsDigit(splitStr[splitStrLength - i]) == true)
                {
                    check = true;
                }
                else
                {
                    break;
                }
            }
            if (i == 3 && Char.IsDigit(splitStr[splitStrLength - 4]) == true)
            {
                check = false;
            }
          
            return check;
        }
    }
}
