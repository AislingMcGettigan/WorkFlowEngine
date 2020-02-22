using System;
using System.Collections.Generic;

namespace WorkflowEngine.Interfaces
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
