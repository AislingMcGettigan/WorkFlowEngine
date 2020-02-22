using System;
using WorkflowEngine.Interfaces;

namespace WorkflowEngine
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email");
        }
    }
}
