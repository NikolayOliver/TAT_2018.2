using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTasks
{
    class Stackwork
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Present work Stack");
            Console.WriteLine("Input size of Stack");
            int size = int.Parse(Console.ReadLine());
            Stack st = new Stack(size);
            while (true)
            {
                try
                {   
                    Menu showMenu = new Menu();
                    Console.WriteLine("Input choose");
                    int choose = int.Parse(Console.ReadLine());
                    if (choose == 4) break;
                    showMenu.ShowWork(choose, st);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! Try again!");
                }

            }
         //   Console.ReadKey();
        }
    }
}
