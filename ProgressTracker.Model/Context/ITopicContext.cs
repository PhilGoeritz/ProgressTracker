using Microsoft.EntityFrameworkCore;
using ProgressTracker.Data.Model;

namespace ProgressTracker.Data.Context
{
    public interface ITopicContext
    {
        DbSet<TimeInstanceData> TimeInstances { get; set; }
        DbSet<TopicData> Topics { get; set; }
    }
}