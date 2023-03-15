using Microsoft.EntityFrameworkCore;
using ProgressTracker.Data.Model;

namespace ProgressTracker.Data.Context
{
    internal sealed class TopicContext : DbContext, ITopicContext
    {
        public DbSet<TopicData> Topics { get; set; }
        public DbSet<TimeInstanceData> TimeInstances { get; set; }

        public TopicContext(DbSet<TopicData> topics, DbSet<TimeInstanceData> timeInstances)
        {
            Topics = topics;
            TimeInstances = timeInstances;
        }
    }
}
