using System.Collections;
using System.Collections.Generic;

namespace Illallangi.TripIt
{
    public class JsonCollection<T> : ICollection<T>
    {
        public JsonCollection(ICollection<T> collection)
        {
            Inner = collection;
        }

        public int Count => Inner.Count;

        public bool IsReadOnly => Inner.IsReadOnly;

        private ICollection<T> Inner { get; }

        public void Add(T item) => Inner.Add(item);

        public void Clear() => Inner.Clear();

        public bool Contains(T item) => Inner.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => Inner.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => Inner.GetEnumerator();

        public bool Remove(T item) => Inner.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => Inner.GetEnumerator();
    }
}