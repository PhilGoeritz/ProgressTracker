namespace ProgressTracker.Business.Model
{
    public sealed class Topic : ModelObject
    {
        public string Title { get; }
        public string Motivation { get; }

        public Topic(Guid id, string title, string motivation)
            : base(id)
        {
            Title = title;
            Motivation = motivation;
        }
    }
}
