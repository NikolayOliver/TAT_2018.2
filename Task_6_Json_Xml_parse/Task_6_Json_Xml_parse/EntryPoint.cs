using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Task_6_Json_Xml_parse
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            
            try
            {
                string path = args[0];
                var writeInFile = new CheckingOnSpecialSymbols(path);
                writeInFile.Check();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!" + e.Message);
            }
            
        }
    }
}
