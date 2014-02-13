using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    /*implement a call center,
     * a call must allocated to c respondent who is free
     * if respondent can not handle the call. 
     * he assign it to his supervisor.
     * if the supoervisor can not handler, send to his director
     
     */

    public enum Status
    {
        Busy,
        Free
    }
    public class Call
    {
        public string caller;
        public string issue;
        public Employee Handler;
    }

    public class Employee
    {
        public string Name;
        public Employee Supervisor;
        public Status Status;
        public bool CanReceiveCall;

        public bool AssignCall(Call call); // send the call to supervisor
        public bool TakeCall(Call call); // try to handl the call, if not then reassign the call to ...
    }

    public class Supervisor : Employee
    {
    }

    public class Director : Supervisor
    {
        public override bool TakeCall(Call call); // can not ressign the call. 
    }

    class CallCenter
    {
        List<Employee> Response;
        List<Supervisor> Supervisors;
        List<Director> Directors;

        public static CallCenter GetInstance()
        {
            return new CallCenter();
        }

        public Employee DispatchCall(Call call)
        {
            foreach (Employee e in this.Response)
            {
                if (e.CanReceiveCall)
                {
                    e.TakeCall(call);
                    return e;
                }
            }
            foreach (Supervisor s in this.Supervisors)
            {
                if (s.CanReceiveCall)
                {
                    s.TakeCall(call);
                    return s;
                }
            }
            foreach (Supervisor s in this.Directors)
            {
                if (s.CanReceiveCall)
                {
                    s.TakeCall(call);
                    return s;
                }
            }
            return null;
        }
    }
}
