using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5_Patern_Comand
{
    // discovery list of Avtos 
    // connect similar avtos
    // calculate count all avtos, count brand,
    // average price all avtos
    // and average price "BMV" Type
    // Field: List<string> listCars
    class Avto
    {
        List<string> listCars =
            new List<string>();
        // return Count Brands
        public virtual int CountBrands()
        {
            return listCars.Count()/4;
        }
        // return Count all avtos
        public virtual int CountAll()
        {
            int countAll = 0;
            for (int i = 1; i < listCars.Count(); i += 4)
            {
                countAll += int.Parse(listCars[i]);
            }
            return countAll;
        }
        // return average price all avtos
        public virtual double AveragePrice()
        {
            double averagePrice = 0;
            int count = 0;
            // i - count, i+2 - costOne
            for (int i = 1; i < listCars.Count(); i += 4)
            {
                averagePrice += int.Parse(listCars[i]) * int.Parse(listCars[i + 2]);
                count += int.Parse(listCars[i]);
            }
            return averagePrice / count;
        }
        // return average price "BMV" Type
        public virtual double AveragePriceType()
        {
            string brandCar = "BMV";
            // i - brand, i+3 - costOne
            int costOne = 0;
            for (int i = 0; i < listCars.Count(); i += 4)
            {
                if (brandCar == listCars[i])
                {
                    costOne = int.Parse(listCars[i + 3]);
                    break;
                }
            }
            return costOne;
        }
        // Discovery list avtos
        // throw FormattException if data is uncorrectable
        public virtual void DiscoveryListCars(string brand, string count, string model, string costOne)
        {
            // add first, if list cars is empty 
            if (listCars.Count == 0)
            {
                listCars.Add(brand);
                listCars.Add(count);
                listCars.Add(model);
                listCars.Add(costOne);
            }
            // if list cats is not empty
            else
            {
                // i - brand, i+1 - count, i+2 - model, i+3 - costOne
                int listCount = listCars.Count();
                bool checkBrand = true;
                for (int i = 0; i < listCount; i += 4)
                {
                    if (listCars[i] == brand)
                    {
                        if (listCars[i + 2] == model && listCars[i + 3] == costOne)
                        {
                            listCars[i+1] = (int.Parse(listCars[i + 1]) + int.Parse(count)).ToString();
                            checkBrand = false;
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                }
                // if all brands in out list cars is not equal new brand 
                if (checkBrand == true)
                {
                    listCars.Add(brand);
                    listCars.Add(count);
                    listCars.Add(model);
                    listCars.Add(costOne);
                }
            }
        }

    }
}
