using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ipAdress
{
    class EntryPoint
    {
        static int Main(string[] args)
        {
            try
            {
                //if (args.Length != 1)
                //{
                //    throw new FormatException();
                //}
                string str = "sndfnsn45.15.225.34sdlfj";
                var ipAdress = new IpAdress(str);
                var ip = ipAdress.GetIP();
                Console.WriteLine(ip.Count());
                foreach(List<string> list in ip)
                {
                    Console.Write("IP - ");
                    foreach(string st in list)
                    {
                        Console.Write(st + '.');
                    }
                    Console.WriteLine();
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
