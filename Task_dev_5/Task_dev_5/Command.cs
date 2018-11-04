using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5
{
    // transmit command
    // field - command responsible of incomming command 
    class Command : ICommand
    {
        ICommand command;
        public Command(ICommand com)
        {
            command = com;
        }
        public void Execute()
        {
            command.Execute();
        }
    }
}
