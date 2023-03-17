using DynamicData;
using ProgressTracker.Data.Model;

namespace ProgressTracker.Data.Repositories
{
    public interface IDataRepositoryObservable<T> where T : DataObject
    {
        IObservable<IChangeSet<T>> ChangeSet { get; }
    }

    internal interface IDataRepository<T> where T : DataObject
    {
        T Get(Guid itemId);
        void Add(T item);
        void Remove(Guid itemId);
        void Remove(T item);
        void Update(T newItemData);
    }

    internal abstract class DataRepository<T> : IDataRepository<T>, IDataRepositoryObservable<T> where T : DataObject
    {
        protected readonly SourceList<T> _sources;

        public IObservable<IChangeSet<T>> ChangeSet => _sources.Connect();

        protected DataRepository()
        {
            _sources = new SourceList<T>();
        }

        public T Get(Guid itemId)
        {
            return _sources.Items.Single(item => item.Id.Equals(itemId));
        }

        public void Add(T item)
        {
            _sources.Add(item);
        }

        public void Remove(Guid itemId)
        {
            var item = _sources.Items.Single(item => item.Id.Equals(itemId));
            _sources.Remove(item);
        }

        public void Remove(T item)
        {
            _sources.Remove(item);
        }

        public void Update(T newItemData)
        {
            var oldItemData = _sources.Items.Single(item => item.Id.Equals(newItemData.Id));

            _sources.Replace(oldItemData, newItemData);
        }
    }
}
