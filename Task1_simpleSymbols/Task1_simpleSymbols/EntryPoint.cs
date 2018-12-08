using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1_simpleSymbols
{
    // Entry Point to programm
    // Accept a string as an argument of commant line
    // and write the numbers of occurrences of each charecter in it
    // Exception: uncorrectable count of arguments
    // should be only 1
    // Return: 0 if everything is ok
    // 1 if arguments of command line != 1
    // 2 another Exception
    class EntryPoint
    {
        static int Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new FormatException();
                }
                var simpleSymbols = new SimpleSymbols(args[0]);
                var simpleSymbolsDictionary = simpleSymbols.FindingSimpleSymbols();
                foreach (KeyValuePair<char, int> keyValue in simpleSymbolsDictionary)
                {
                    Console.WriteLine("\'{0}\' - {1}", keyValue.Key, keyValue.Value);
                }
                return 0;
            }
            catch (FormatException f)
            {
                Console.WriteLine("Should be only 1 argument!");
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                return -2;
            }
        }
    }
}

