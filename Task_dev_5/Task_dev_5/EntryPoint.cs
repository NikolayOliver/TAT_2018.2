using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5
{
    class EntryPoint
    {
        // this enum for (switch case)
        enum command
        {
            countTypes = 1,
            countAll,
            averagePrice,
            averagePriceType,
            exit
        }
        // Entry Point
        static int Main(string[] args)
        {
            try
            {   // file path
                string path = @"c:\Users\User\Source\Repos\TAT_2018.2\Task_dev_5\Task_dev_5\List of Cars.txt";
                var carsAdder = new CarsAdder();
                string brandPrice;
                List<string> carOptions = carsAdder.CarsAdd(path);
                CountTypesHandler countTypes = new CountTypesHandler(carOptions);
                CountAllHandler countAll = new CountAllHandler(carOptions);
                AveragePriceHandler averagePrice = new AveragePriceHandler(carOptions);
                Invoker invoker = new Invoker();
                int chooser;
                while (true) 
                {
                    chooser = int.Parse(Console.ReadLine());
                    // checking to exit
                    if(chooser == 5)
                    {
                        break;
                    }
                    switch ((command)chooser)
                    {
                        case command.countTypes:
                            invoker.SetCommand(new Command(new CountTypesCommand(countTypes)));
                            invoker.DoCommandFunction();
                            break;
                        case command.countAll:
                            invoker.SetCommand(new Command(new CountAllCommand(countAll)));
                            invoker.DoCommandFunction();
                            break;
                        case command.averagePrice:
                            invoker.SetCommand(new Command(new AveragePriceCommand(averagePrice)));
                            invoker.DoCommandFunction();
                            break;
                        case command.averagePriceType:
                            brandPrice = Console.ReadLine();
                            // create here, because need input which cars brand want to see client
                            AveragePriceTypeHandler averagePriceType = new AveragePriceTypeHandler(carOptions, brandPrice);
                            invoker.SetCommand(new Command(new AverageTypePriceCommand(averagePriceType)));
                            break;
                        default:
                            throw new Exception("No such option");
                    }
                }
                return 0;
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
    
        }
    }
}
