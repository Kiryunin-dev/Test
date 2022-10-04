using Quartz;
using System;

namespace Project1.Jobs
{
    public class TestJob: IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.FromResult(() =>
            {
                Console.WriteLine("JOB1", DateTime.Now);
            });
        }
    }
}
