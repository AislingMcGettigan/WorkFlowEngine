using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new Workflow();
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());


            var engine = new WorkflowEngine();
            engine.Run(workFlow);
            Console.ReadLine();
        }
    }
}
