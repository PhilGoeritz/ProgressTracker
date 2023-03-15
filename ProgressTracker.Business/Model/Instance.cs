namespace ProgressTracker.Business.Model
{
    public sealed class TimeInstance : ModelObject
    {
        public Guid TopicId { get; }

        public DateTime Date { get; }
        public DateTime Time { get; }

        public TimeInstance(Guid id, Guid topicId, DateTime date, DateTime time)
            : base(id)
        {
            TopicId = topicId;
            Date = date;
            Time = time;
        }
    }
}
