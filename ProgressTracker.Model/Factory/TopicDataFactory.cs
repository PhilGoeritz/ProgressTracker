using ProgressTracker.Data.Model;
using ProgressTracker.Data.Repositories;

namespace ProgressTracker.Data.Factory
{
    public interface ITopicDataFactory
    {
        void Create(string title, string description);
        void Delete(Guid topicId);
    }

    internal sealed class TopicDataFactory : ITopicDataFactory
    {
        private readonly ITopicDataRepository topicRepository;
        private readonly ITimeInstanceDataDataRepository timeInstanceRepository;

        public TopicDataFactory(
            ITopicDataRepository topicRepository,
            ITimeInstanceDataDataRepository timeInstanceRepository)
        {
            this.topicRepository = topicRepository;
            this.timeInstanceRepository = timeInstanceRepository;
        }

        public void Create(string title, string description)
        {
            topicRepository.Add(
                new TopicData(
                    Guid.NewGuid(),
                    title,
                    description));
        }

        public void Delete(Guid topicId)
        {
            topicRepository.Remove(topicId);
            timeInstanceRepository.RemoveByTopicId(topicId);
        }
    }
}
