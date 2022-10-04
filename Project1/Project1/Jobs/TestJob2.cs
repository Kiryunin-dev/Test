using Quartz;
using System;

namespace Project1.Jobs
{
    public class TestJob2: IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.FromResult(() =>
            {
                Console.WriteLine("JOB2", DateTime.Now);
            });
        }
    }
}
