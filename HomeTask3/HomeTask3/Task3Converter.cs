using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeTask3
{
    class Task3Converter
    {
        static int Main(string[] args)
        {
            try
            {   
                if (args.Length > 2)
                {
                    Console.WriteLine ("Input only 2 arguments");
                    return -1;
                }
                int number = int.Parse (args[0]);
                int newBase = int.Parse (args[1]);
                if (newBase > 20 || newBase < 2)
                {
                    Console.WriteLine ("Second argument should be from 2 to 20");
                }
                NumberConverter intNumber = new NumberConverter (number, newBase);
                StringBuilder numberInNewbase = new StringBuilder();
                intNumber.Converter (numberInNewbase);
                Console.WriteLine (numberInNewbase);
                return 0;
            }
            catch( FormatException )
            {
                Console.WriteLine ("You should input only integer number and base system");
                return -1;
            }
            catch( Exception e )
            {
                Console.WriteLine ("Error: " + e.Message);
                return -1;
            }
        }
    }
}
