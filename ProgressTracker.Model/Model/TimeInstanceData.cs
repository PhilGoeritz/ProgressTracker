using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressTracker.Data.Model
{
    [Table("TimeInstances")]
    public sealed class TimeInstanceData : DataObject
    {
        public Guid TopicId { get; }

        public DateTime Date { get; }
        public DateTime Time { get; }

        public TimeInstanceData(Guid id, Guid topicId, DateTime date, DateTime time)
            : base(id)
        {
            TopicId = topicId;
            Date = date;
            Time = time;
        }
    }
}
