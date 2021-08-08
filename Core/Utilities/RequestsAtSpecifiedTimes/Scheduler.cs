using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.RequestsAtSpecifiedTimes
{
   public class Scheduler
    {
        public  async void InitializeJobs()
        {
            var _scheduler = await new StdSchedulerFactory().GetScheduler();
            await _scheduler.Start();

            var SendRequestJob = JobBuilder.Create<SendRequest>()
                .WithIdentity("SendRequestJob")
                .Build();
            var SendRequestTrigger = TriggerBuilder.Create()
                .WithIdentity("SendRequestCron")
                .StartAt(DateTime.UtcNow).WithSimpleSchedule(x => x.WithIntervalInSeconds(1000).RepeatForever())
                //.WithCronSchedule("* * * ? * *")
                .Build();

            var result = await _scheduler.ScheduleJob(SendRequestJob, SendRequestTrigger);
        }

    }
}
