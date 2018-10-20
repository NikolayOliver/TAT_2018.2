using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTasks
{
    class Stack
    {
        private int maxSize;
        private int actualSize;
        private int[] stack;
        private int[] newStack;
        public Stack()
        {
            maxSize = 0;
            Console.WriteLine("You create stack with size = 0!");
            actualSize = 0;
        }
        public Stack(int maxSize)
        {
            Console.Write("You create stack with size = ");
            Console.WriteLine(maxSize);
            stack = new int[maxSize];
            this.maxSize = maxSize;
            actualSize = 0;
        }
        public void ReSize(int maxSize, int reSize)
        {
            if (maxSize <= reSize)
            {
                Console.WriteLine("Error! You cann't ReSize! New Size should be more than max Size.");
                return;
            }
            else
            {
                newStack = new int[reSize];
                for (int i = 0; i < actualSize; i++)
                {
                    newStack[i] = stack[i];
                }
                //newStack = stack;
                stack = new int[reSize];
                for (int i = 0; i < actualSize; i++)
                {
                    stack[i] = newStack[i];
                }

                //stack = newStack;
                this.maxSize = reSize;
            }
        }
        public int Pop()
        {
            if (actualSize == 0)
            {
                Console.WriteLine("Error! There is nothing to pop");
                throw new Exception();
            }
            else
            {
                int popElem = stack[actualSize];
                actualSize--;
                return popElem;
            }

            
        }
        public void Push(int value)
        {
            if (actualSize < maxSize)
            {
                stack[actualSize] = value;
                actualSize++;
            }
            else
                Console.WriteLine("Stack is full, use ReSize or Pop");
        }
        public int GetHead()
        {
            if(actualSize == 0)
            {
                Console.WriteLine("Nothing to GetHead");
                throw new Exception();
            }
            else
                return stack[actualSize];
        }
    }
}
