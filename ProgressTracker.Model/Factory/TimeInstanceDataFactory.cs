using ProgressTracker.Data.Model;
using ProgressTracker.Data.Repositories;

namespace ProgressTracker.Data.Factory
{
    public interface ITimeInstanceDataFactory
    {
        void Create(Guid topicId, DateTime date, DateTime time);
        void Delete(Guid instanceId);
    }

    internal sealed class TimeInstanceDataFactory : ITimeInstanceDataFactory
    {
        private readonly ITimeInstanceDataDataRepository timeInstanceRepository;

        public TimeInstanceDataFactory(ITimeInstanceDataDataRepository timeInstanceRepository)
        {
            this.timeInstanceRepository = timeInstanceRepository;
        }

        public void Create(Guid topicId, DateTime date, DateTime time)
        {
            timeInstanceRepository.Add(
                new TimeInstanceData(
                    Guid.NewGuid(),
                    topicId,
                    date,
                    time));
        }

        public void Delete(Guid instanceId)
        {
            timeInstanceRepository.Remove(instanceId);
        }
    }
}
