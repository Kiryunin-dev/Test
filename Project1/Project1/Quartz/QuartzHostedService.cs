using Quartz;
using Quartz.Spi;

namespace Project1.Quartz
{
    public class QuartzHostedService : IHostedService
    {
        private readonly IJobFactory _jobFactory;
        private readonly ISchedulerFactory _schedulerFactory;
        private readonly IEnumerable<JobShedule> _jobShedules;

        public QuartzHostedService(IJobFactory jobFactory, ISchedulerFactory schedulerFactory, IEnumerable<JobShedule> jobShedules)
        {
            _jobFactory = jobFactory;
            _schedulerFactory = schedulerFactory;
            _jobShedules = jobShedules;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(() => { });
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
