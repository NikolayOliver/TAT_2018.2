using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5
{
    // check what brand client input and then input average price cars of this brand
    // field - averageTypePrice
    class AveragePriceTypeHandler
    {
        double averageTypePrice;
        // if such brand is in list of cars, averageTypePrice = CheckBrand
        // else throw exeption
        public AveragePriceTypeHandler(List<string> optionsCars, string brandPrice)
        {
            if ( CheckBrand(optionsCars,brandPrice) == -1)
            {
                throw new Exception("This brand is not exist");
            }
            else
            {
                averageTypePrice = CheckBrand(optionsCars, brandPrice);
            }
        }
        // Check every brands and if such brand is in list of cars return index this brand
        // else return -1
        public int CheckBrand(List<string> optionsCars, string brandPrice)
        {   // if inpitting is correct each duscibing of cars consists of 4 elements
            for (int i = 0; i < optionsCars.Count; i += 4)
            {
                if (optionsCars[i] == brandPrice)
                {
                    return i;
                }
            }
            return -1;
        }

        public void AverageTypePrice()
        {
            Console.WriteLine(averageTypePrice);
        }
    }
    
    class AverageTypePriceCommand : ICommand
    {
        AveragePriceTypeHandler averagePrice;
        public AverageTypePriceCommand(AveragePriceTypeHandler averagePrc)
        {
            averagePrice = averagePrc;
        }
        public void Execute()
        {
            averagePrice.AverageTypePrice(); 
        }
    }
}
