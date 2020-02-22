
using WorkflowEngine.Interfaces;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach(ITask task in workflow.GetTasks())
            {
                task.Execute();
            }
        }
    }
}
