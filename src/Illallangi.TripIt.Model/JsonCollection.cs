using System.Collections;
using System.Collections.Generic;

namespace Illallangi.TripIt.Model
{
    public class JsonCollection<T> : ICollection<T>
    {
        public JsonCollection(ICollection<T> collection)
        {
            this.Inner = collection;
        }

        public int Count => this.Inner.Count;

        public bool IsReadOnly => this.Inner.IsReadOnly;

        private ICollection<T> Inner { get; }

        public void Add(T item) => this.Inner.Add(item);

        public void Clear() => this.Inner.Clear();

        public bool Contains(T item) => this.Inner.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => this.Inner.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => this.Inner.GetEnumerator();

        public bool Remove(T item) => this.Inner.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => this.Inner.GetEnumerator();
    }
}