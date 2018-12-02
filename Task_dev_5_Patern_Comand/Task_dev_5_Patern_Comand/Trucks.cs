using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace Task_dev_5_Patern_Comand
{
    // Child of Avto
    // load Trucks.xml with discription of trucks
    // and discovery this discription with help base class Avto
    // field XDocument xDocCars which consist of discription of trucks
    // thrrow Formatexception if list is uncorrectable
    class Trucks : Avto
    {
        XDocument xDocCars;
        List<string> listTrucks = new List<string>();
        public Trucks()
        {
            xDocCars = XDocument.Load("Trucks.xml");
            foreach (XElement truckElement in xDocCars.Element("trucks").Elements("truck"))
            {
                XAttribute brand = truckElement.Attribute("name");
                XElement count = truckElement.Element("count");
                XElement model = truckElement.Element("model");
                XElement costOne = truckElement.Element("costOne");
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
            base.DiscoveryListCars(brand, count, model, costOne);
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
        public override int CountBrands()
        {
            return base.CountBrands();
        }
    }
}
