using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5_Patern_Comand
{
    class CommandCountBrands : Icommand
    {
        // Write value Count Brands avtos (cars or trucks)
        // Have 1 field Avto
        Avto avto;
        public CommandCountBrands(Avto auto)
        {
            avto = auto;
        }
        public void Execute()
        {
            Console.WriteLine("Count Brands: " + avto.CountBrands());
        }
    }
}
