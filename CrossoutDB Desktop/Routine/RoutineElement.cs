using System.Threading.Tasks;
using System.Threading;
using System;

namespace Routine
{
    public class RoutineAction
    {
        public readonly Task Task;
        public readonly string Description;

        public event Action OnFineshed;

        public RoutineAction(Task target,string description)
        {
            target.GetAwaiter().OnCompleted(Finalized);
        }

        public void Finalized()
        {
            OnFineshed.Invoke();
        }

        public static RoutineAction GetWaitRoutine(int time)
        {
            return new RoutineAction(Task.Run(() => { Thread.Sleep(time); }),$"Waiting for {time}.");
        }
    }
}