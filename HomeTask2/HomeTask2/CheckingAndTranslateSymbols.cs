using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class CheckingAndTranslateSymbols
    {
        // this function check each input symbol
        // return true, if all symbol is letter
        // else return false
        public bool CheckingSymbols(string[] args)
        {
            char[] argToChar;
            foreach(string arg in args)
            {
                argToChar = arg.ToCharArray();
                foreach(char symbol in argToChar)
                {
                    if(char.IsLetter(symbol) == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // function translate russian letters in english
        // and back
        public string Translate(char symbol, Dictionary<char, string> translationDictionary)
        {
            foreach (KeyValuePair<char, string> dictionary in translationDictionary)
            {
                if (dictionary.Key == symbol)
                {
                    return dictionary.Value;
                }
                
            }
            return "$$";
        }
    }

 
}
