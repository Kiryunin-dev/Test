using System;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;
using Quartz.Impl;

namespace Project1.Quartz
{
    using Jobs;

    public static class QurtzExtension
    {
        public static void ConfigureQuartz(this IServiceCollection collection)
        {
            collection.AddSingleton<IJobFactory, JobFactory>();
            collection.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();


            collection.AddSingleton<IJob, TestJob>();
            collection.AddSingleton(new JobShedule(typeof(TestJob), "0 1 * * * ?"));

            collection.AddSingleton<IJob, TestJob2>();
            collection.AddSingleton(new JobShedule(typeof(TestJob2), "0 1 * * * ?"));

            collection.AddHostedService<QuartzHostedService>();
        }
    }
}
