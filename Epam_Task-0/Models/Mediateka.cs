using Epam_Task_0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam_Task_0.Models
{
    public class Mediateka : IMediateka
    {
        private readonly IDictionary<int, MediatekaItem> _items;
        private readonly IDictionary<int, IMediatekaList> _lists;

        public Mediateka()
        {
            _items = new Dictionary<int, MediatekaItem>();
            _lists = new Dictionary<int, IMediatekaList>();
        }
        public Mediateka(IDictionary<int, MediatekaItem> items)
        {
            _items = items;
            _lists = new Dictionary<int, IMediatekaList>();
        }
        public Mediateka(IDictionary<int, IMediatekaList> lists)
        {
            _items = new Dictionary<int, MediatekaItem>();
            _lists = lists;
        }
        public Mediateka(IDictionary<int, MediatekaItem> items,
                         IDictionary<int, IMediatekaList> lists)
        {
            _items = items;
            _lists = lists;
        }

        public void AddItem(MediatekaItem item)
        {
            _items.Add(item.Id, item);
        }

        public void AddList(IMediatekaList list)
        {
            _lists.Add(list.Id, list);
        }

        public void RemoveItem(int id)
        {
            if (_items.ContainsKey(id))
            {
                _items.Remove(id);
            }
        }

        public void RemoveList(int id)
        {
            if (_lists.ContainsKey(id))
            {
                _lists.Remove(id);
            }
        }

        public MediatekaItem FindItemById(int id)
        {
            return _items[id];
        }

        public IMediatekaList FindListById(int id)
        {
            return _lists[id];
        }

        public MediatekaItem FindItem(Func<MediatekaItem, bool> predicate)
        {
            return _items.Values.FirstOrDefault(predicate);
        }

        public IMediatekaList FindList(Func<IMediatekaList, bool> predicate)
        {
            return _lists.Values.FirstOrDefault(predicate);
        }
    }
}
