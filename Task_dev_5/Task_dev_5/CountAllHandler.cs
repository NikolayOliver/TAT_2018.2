using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5
{
    // Calculate and write count of all cars
    // field - countAll - count of all cars
    class CountAllHandler
    {
        int countAll = 0;
        // Calculate number of all cars
        public CountAllHandler(List<string> optionsCars)
        {
            // 2 - first appearance of the number of cars, 4 - total command
            for(int i = 2; i < optionsCars.Count; i+=4)
            {
                countAll += int.Parse(optionsCars[i]); 
            }
        }
        public void CountAll()
        {
            Console.WriteLine(countAll);
        }
    }
    // 
    class CountAllCommand:ICommand
    {
        CountAllHandler countAll;
        public CountAllCommand(CountAllHandler cntAll)
        {
            countAll = cntAll;
        }
        public void Execute()
        {
            countAll.CountAll();
        }
    }
}
