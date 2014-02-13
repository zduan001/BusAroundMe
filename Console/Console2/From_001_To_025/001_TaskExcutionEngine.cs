using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2
{
    public class _001_TaskExcutionEngine
    {
        /// <summary>
        /// Give a task, excute it. this task depend on many other tasks, those tasks are listed
        /// in the dependency list of the task. depency task has to be excuted before the task.
        /// 1. circular dependency has be detected and throw expcetion.
        /// 2. dependucytask only need to be run once, even it is depency of a lot of other tasks.
        /// </summary>
        /// <param name="availableTasks"></param>
        /// <param name="input"></param>
        public void ExcuteTask(List<Task> availableTasks, Task input)
        {
            HashSet<Task> excuted = new HashSet<Task>();
            HashSet<Task> waitingTasks = new HashSet<Task>();
            taskExcution = new StringBuilder();

            ExcuteTaskWorker(availableTasks, input, excuted, waitingTasks);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="availableTasks"></param>
        /// <param name="input"></param>
        /// <param name="excuted"></param>
        /// <param name="waitingList"></param>
        public void ExcuteTaskWorker(List<Task> availableTasks, Task input, HashSet<Task> excuted, HashSet<Task> waitingList)
        {

            if (input.DepencyTasks == null || input.DepencyTasks.Count == 0)
            {
                taskExcution.Append(input.Name + ",");
                excuted.Add(input);
                waitingList.Remove(input);
                return;
            }

            if (excuted.Contains(input))
            {
                return;
            }
            if (waitingList.Contains(input))
            {
                throw new Exception("Circular dependency detected");
            }
            else
            {
                waitingList.Add(input);
            }

            foreach (Task t in input.DepencyTasks)
            {
                ExcuteTaskWorker(availableTasks, t, excuted, waitingList);
            }

            // after all child excute  the root.
            taskExcution.Append(input.Name + ",");
            excuted.Add(input);
            waitingList.Remove(input);
        }

        public StringBuilder taskExcution;
    }

    public class Task
    {
        public Task(string s)
        {
            Name = s;
            DepencyTasks = new List<Task>();
        }
        public string Name;
        public List<Task> DepencyTasks;
    }
}
