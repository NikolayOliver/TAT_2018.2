using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5
{
    // Calculate all brands cars and write number of them
    // field countTypes = count of brands cars
    class CountTypesHandler
    {
        double countTypes;
        public CountTypesHandler(List<string> optionsCars)
        {
            //if inpitting is correct each duscibing of cars consists of 4 elements            
            countTypes = (optionsCars.Count) / 4;
        }
        public void CountTypes()
        {
            Console.WriteLine(countTypes);
        }
    }

    class CountTypesCommand:ICommand
    {
        CountTypesHandler countTypes;
        public CountTypesCommand(CountTypesHandler cntTypes)
        {
            countTypes = cntTypes;
        }
        public void Execute()
        {
            countTypes.CountTypes();
        }
    }
}
