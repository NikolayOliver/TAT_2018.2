using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTasks
{
    class Menu
    {
        public Menu()
        {
            Console.WriteLine("Choose variant:\n1 - Pop;\n2 - Push;\n3 - GetHead;\n4 - Exit");
        }

        public void ShowWork(int choose, Stack stack)
        {
            int stackHead;
            switch (choose)
            {
                case 1:
                    stackHead = stack.Pop();
                    StringBuilder strOut = new StringBuilder("Element is");
                    strOut.Append(stackHead);
                    Console.WriteLine(strOut);
                    break;
                case 2:
                    Console.WriteLine("Choose value to add");
                    int valueToAdd;
                    
                    while(true)
                    {
                        try
                        {
                            valueToAdd = int.Parse(Console.ReadLine());
                            break; 
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Error of input, try again");
                        }
                    }
                    stack.Push(valueToAdd);
                    break;
                case 3:
                    stackHead = stack.GetHead();
                    StringBuilder strOut1 = new StringBuilder("Element is");
                    strOut1.Append(stackHead);
                    Console.WriteLine(strOut1);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Error your choose is not find");
                    break;
            }

        }
        
    }
}
