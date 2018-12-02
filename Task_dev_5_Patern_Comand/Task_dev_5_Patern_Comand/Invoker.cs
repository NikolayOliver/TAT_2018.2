using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_5_Patern_Comand
{
    // set the incomming command
    // and invokes the method Execute in command
    // field Icommand command
    class Invoker
    {
        Icommand command;
        // set the incomming command
        public void SetCommand(Icommand com)
        {
            command = com;
        }
        public void DO()
        {
            if(command!=null)
            {
                command.Execute();
            }
        }
    }
}
