
using System;
using WorkflowEngine.Interfaces;

namespace WorkflowEngine
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing Status");
        }
    }
}
