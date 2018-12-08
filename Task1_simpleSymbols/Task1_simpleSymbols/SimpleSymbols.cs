using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1_simpleSymbols
{
    // accept string and transform her to Dictionary<char,int>
    // where char - each symbol in string 
    // and int - count of symbol
    // Field: string ourString
    // and Dictionary<char,int> simpleSymbols
    class SimpleSymbols
    {
        string ourString;
        Dictionary<char, int> simpleSymbols = new Dictionary<char, int>();
        public SimpleSymbols(string str)
        {
            ourString = str;
        }
        // in each symbol in ourString check
        // if this symbol is in Dictionary
        // count of it increase by 1
        // else add symbol in Dictionary<char,int>
        // with count of it 1
        // Return Dictionary<char,int>
        public Dictionary<char, int> FindingSimpleSymbols()
        {
            foreach (char symbol in ourString)
            {
                if (simpleSymbols.ContainsKey(symbol) == false)
                {
                    simpleSymbols.Add(symbol, 1);
                }
                else
                {
                    simpleSymbols[symbol]++;
                }
            }
            return simpleSymbols;
        }

    }
}

