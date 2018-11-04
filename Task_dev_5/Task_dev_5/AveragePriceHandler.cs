using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5
{
    class AveragePriceHandler
    {
        int countAll;
        int priceAll;
        double averagePrice;
        public AveragePriceHandler(List<string> optionsCars)
        {
            // Calculate number of all cars
            // 2 - first appearance of the number of cars, 4 - total command
            // 3 (i+1) - count cars
            for (int i = 2; i < optionsCars.Count; i += 4)
            {
                countAll += int.Parse(optionsCars[i]);
                priceAll += int.Parse(optionsCars[i]) * int.Parse(optionsCars[i + 1]);
            }
            averagePrice = priceAll / countAll;
        }
        public void AveragePrice()
        {
            Console.WriteLine(averagePrice);
        }
    }
    class AveragePriceCommand:ICommand
    {
        AveragePriceHandler averagePrice;
        public AveragePriceCommand(AveragePriceHandler averagePrc)
        {
            averagePrice = averagePrc;
        }
        public void Execute()
        {
            averagePrice.AveragePrice();
        }

    }

}
