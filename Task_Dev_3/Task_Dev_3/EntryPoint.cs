using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Dev_3
{
    class EntryPoint
    {

        static int Main(string[] args)
        {
            try
            {
                if (args.Length > 2)
                {
                    Console.WriteLine("Input only 2 arguments");
                    return -1;
                }
                int number = int.Parse(args[0]);
                int newBase = int.Parse(args[1]);
                NumberConverter intNumber = new NumberConverter(number,newBase);

                Console.WriteLine(intNumber.Converter());
                Console.ReadKey();
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("You should input only integer number and base system should be more 2 and less 20");
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return -2;
            }
        }

    }
}
