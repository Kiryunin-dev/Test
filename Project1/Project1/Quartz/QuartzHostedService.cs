using Quartz;
using Quartz.Spi;

namespace Project1.Quartz
{
    public class QuartzHostedService : IHostedService
    {
        private readonly IJobFactory jobFactory;
        private readonly ISchedulerFactory schedulerFactory;
        private readonly IEnumerable<>


        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
