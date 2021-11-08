using Epam_Task_0.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Epam_Task_0.Models.Lists
{
    public class MediatekaList : IMediatekaList
    {
        private readonly ICollection<MediatekaItem> _items;

        public int Id { get; }

        public MediatekaList(int id)
        {
            Id = id;
            _items = new List<MediatekaItem>();
        }

        public MediatekaList(int id, IList<MediatekaItem> items)
        {
            Id = id;
            _items = items;
        }

        public void Add(MediatekaItem item)
        {
            _items.Add(item);
        }

        public void Remove(MediatekaItem item)
        {
            _items.Remove(item);
        }

        public IEnumerator<MediatekaItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
