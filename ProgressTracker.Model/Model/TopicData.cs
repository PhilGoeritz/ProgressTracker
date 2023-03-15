using System.ComponentModel.DataAnnotations.Schema;

namespace ProgressTracker.Data.Model
{
    [Table("Topics")]
    public sealed class TopicData : DataObject
    {
        public string Title { get; }
        public string Motivation { get; }

        public TopicData(Guid id, string title, string motivation)
            : base(id)
        {
            Title = title;
            Motivation = motivation;
        }
    }
}
