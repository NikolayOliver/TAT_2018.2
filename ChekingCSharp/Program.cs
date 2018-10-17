using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ChekingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] argsToCharArray;
            List<char> listSymbol = new List<char>(){}; // create empty List
           
            int count = 0;
            int  argsLength = args.Length;
            int max = 0;

             for (int i = 0; i < argsLength - 1;i++ )   
                {
                    argsToCharArray = args[i].ToCharArray();
                    foreach (char symbol in argsToCharArray)
                    {

                        if (listSymbol.Contains(symbol) == false)
                            listSymbol.Add(symbol);
                        else
                        {
                            if (max < count)
                                max = count;
                            count -= (listSymbol.IndexOf(symbol) + 1);
                            listSymbol.RemoveRange(0, listSymbol.IndexOf(symbol) + 1);  // remove elements from the beggining to found element 
                            listSymbol.Add(symbol);

                        }
                        count++;
                    }

                    if (listSymbol.Contains(' ') == false)
                        listSymbol.Add(' ');
                    else
                    {
                        if (max < count)
                            max = count;
                        count -= (listSymbol.IndexOf(' ') + 1);
                        listSymbol.RemoveRange(0, listSymbol.IndexOf(' ') + 1);
                        listSymbol.Add(' ');
                    }
                    count++;
                   
                }
             foreach (char symbol in args[argsLength - 1])
             {

                 if (listSymbol.Contains(symbol) == false)
                     listSymbol.Add(symbol);
                 else
                 {
                     if (max < count)
                         max = count;
                     count -= (listSymbol.IndexOf(symbol) + 1);
                     listSymbol.RemoveRange(0, listSymbol.IndexOf(symbol) + 1);
                     listSymbol.Add(symbol);

                 }
                 count++;
             }

         
            if (max < count)
                max = count;
            Console.WriteLine("Max length of various symbols is "+max);
            Console.ReadKey();
        }
    }
}
