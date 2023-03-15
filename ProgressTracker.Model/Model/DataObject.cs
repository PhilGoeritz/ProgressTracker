using System.ComponentModel.DataAnnotations;

namespace ProgressTracker.Data.Model
{
    public abstract class DataObject
    {
        [Key]
        public Guid Id { get; }

        protected DataObject(Guid id)
        {
            Id = id;
        }
    }
}