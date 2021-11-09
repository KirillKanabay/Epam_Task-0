using Epam_Task_0.Interfaces;
using Epam_Task_0.Interfaces.Generic;
using System.Collections;
using System.Collections.Generic;

namespace Epam_Task_0.Models.Lists
{
    public class MediatekaList<TItem> : IMediatekaList<TItem>
        where TItem : MediatekaItem
    {
        private readonly ICollection<TItem> _items;
        public int Id { get; }
        public MediatekaList(int id)
        {
            Id = id;
            _items = new List<TItem>();
        }
        public MediatekaList(int id, IList<TItem> items)
        {
            Id = id;
            _items = items;
        }

        public void Add(TItem item)
        {
            _items.Add(item);
        }
        public void Remove(TItem item)
        {
            _items.Remove(item);
        }
        void IMediatekaList.Add(MediatekaItem item)
        {
            if(item is TItem)
            {
                Add(item as TItem);
            }
            else
            {
                //todo smth
            }
        }
        void IMediatekaList.Remove(MediatekaItem item)
        {
            if (item is TItem)
            {
                Remove(item as TItem);
            }
            else
            {
                //todo smth
            }
        }
        
        public IEnumerator<TItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
