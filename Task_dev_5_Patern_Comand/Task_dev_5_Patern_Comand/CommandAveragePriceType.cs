using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5_Patern_Comand
{
    // Write value Average price "BMV" avtos (cars or trucks)
    // Have 1 field Avto
    class CommandAveragePriceType : Icommand
    {
        Avto avto;
        public CommandAveragePriceType(Avto auto)
        {
            avto = auto;
        }
        public void Execute()
        {
            Console.WriteLine("Average Price Type: " + avto.AveragePriceType());
            
        }
    }
}
