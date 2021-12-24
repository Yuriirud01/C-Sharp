using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces // Note: actual namespace depends on the project name.
{
    public class WorkFlowEngine
    {
        public static void Run(List <WorkFlow> tasks)
        {
            foreach (WorkFlow task in tasks)
            {
                task.Execute_WorkFlow();
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var worklist = new List<WorkFlow>() { new WorkFlow(new Executor(), "cleaning"), new WorkFlow(new Executor(), "vacuuming") };
            WorkFlowEngine.Run(worklist);
        }
    }
}