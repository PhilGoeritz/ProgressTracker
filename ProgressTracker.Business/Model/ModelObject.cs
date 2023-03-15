namespace ProgressTracker.Business.Model
{
    public abstract class ModelObject
    {
        public Guid Id { get; }

        protected ModelObject(Guid id)
        {
            Id = id;
        }
    }
}
