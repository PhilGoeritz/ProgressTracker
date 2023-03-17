using ProgressTracker.Data.Model;

namespace ProgressTracker.Data.Repositories
{
    public interface ITopicDataRepositoryObservable : IDataRepositoryObservable<TopicData> { }

    internal interface ITopicDataRepository : IDataRepository<TopicData> { }

    internal sealed class TopicDataRepository
        : DataRepository<TopicData>, ITopicDataRepository, ITopicDataRepositoryObservable
    {
        public TopicDataRepository() : base() { }
    }
}
