using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Task_dev_5_Patern_Comand
{
    // Child of Avto
    // load Cars.xml with discription of cars
    // and discovery this discription with help base class Avto
    // field XDocument xDocCars which consist of discription of cars
    // thrrow Formatexception if list is uncorrectable
    class Cars : Avto
    {
        XDocument xDocCars;
        public Cars()
        {
            xDocCars = XDocument.Load("Cars.xml");
            foreach (XElement carElement in xDocCars.Element("cars").Elements("car"))
            {
                XAttribute brand = carElement.Attribute("name");
                XElement count = carElement.Element("count");
                XElement model = carElement.Element("model");
                XElement costOne = carElement.Element("costOne");
                if(brand != null && count != null && model != null && costOne != null)
                {
                    DiscoveryListCars(brand.Value.ToString(), count.Value.ToString(), 
                        model.Value.ToString(), costOne.Value.ToString());
                   
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        public override void DiscoveryListCars(string brand, string count, string model, string costOne)
        {
             base.DiscoveryListCars(brand,count,model,costOne);
        }
        public override int CountBrands()
        {
            return base.CountBrands();
        }
        public override double AveragePrice()
        {
            return base.AveragePrice();
        }
        public override double AveragePriceType()
        {
            return base.AveragePriceType();
        }
        public override int CountAll()
        {
            return base.CountAll();
        }
    }
}
