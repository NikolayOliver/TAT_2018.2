using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5
{
    class Invoker
    {
        ICommand command;
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public void DoCommandFunction()
        {
            if(command != null)
            {
                command.Execute();
            }
        }
    }
}
