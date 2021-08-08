using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Core.Utilities.RequestsAtSpecifiedTimes
{
    public class SendRequest : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));

            return Task.CompletedTask;
        }
    }
}
