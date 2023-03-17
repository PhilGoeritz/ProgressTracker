using DynamicData;
using ProgressTracker.Data.Model;

namespace ProgressTracker.Data.Repositories
{
    public interface ITimeInstanceDataRepositoryObservable : IDataRepositoryObservable<TimeInstanceData> { }

    internal interface ITimeInstanceDataDataRepository : IDataRepository<TimeInstanceData>
    {
        void RemoveByTopicId(Guid topicId);
    }

    internal sealed class TimeInstanceDataRepository
        : DataRepository<TimeInstanceData>, ITimeInstanceDataDataRepository, ITimeInstanceDataRepositoryObservable
    {
        public TimeInstanceDataRepository() : base() { }

        public void RemoveByTopicId(Guid topicId)
        {
            _sources.Edit(instances =>
            {
                var instancesToRemove = instances
                    .Where(instance => instance.TopicId.Equals(topicId))
                    .ToList();

                instances.RemoveMany(instancesToRemove);
            });
        }
    }
}
