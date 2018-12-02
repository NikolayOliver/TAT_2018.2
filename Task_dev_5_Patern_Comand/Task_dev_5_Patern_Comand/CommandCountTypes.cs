using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5_Patern_Comand
{
    // Write value Count All avtos (cars or trucks)
    // Have 1 field Avto
    class CommandCountAll : Icommand
    {
     Avto avto;
        public CommandCountAll(Avto auto)
        {
            avto = auto;
        }
        public void Execute()
        {
            Console.WriteLine("Count All: " + avto.CountAll());
        }
    }
}
