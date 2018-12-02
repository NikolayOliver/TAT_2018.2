using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace Task_dev_5_Patern_Comand
{
    // Entry Point
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Cars cars = new Cars();
                Trucks trucks = new Trucks();
                Invoker invoker = new Invoker();
                List<Icommand> commandList = new List<Icommand>
                {
                    new CommandCountBrands(cars),
                    new CommandCountAll(cars),
                    new CommandAveragePrice(cars),
                    new CommandAveragePriceType(cars),
                    new CommandCountBrands(trucks),
                    new CommandCountAll(trucks),
                    new CommandAveragePrice(trucks),
                    new CommandAveragePriceType(trucks)
                };
                foreach (Icommand c in commandList)
                {
                    invoker.SetCommand(c);
                    // Do all command take turns
                    invoker.DO();
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
