using Epam_Task_0.Factories;
using Epam_Task_0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam_Task_0.Models
{
    public class Mediateka : IMediateka
    {
        private readonly AbstractPlayerFactory _factory; 
        private readonly IDictionary<int, MediatekaItem> _items;
        private readonly IDictionary<int, IMediatekaList> _lists;

        public Mediateka()
        {
            _factory = new PlayerFactrory();
            _items = new Dictionary<int, MediatekaItem>();
            _lists = new Dictionary<int, IMediatekaList>();
        }
        public Mediateka(AbstractPlayerFactory factory)
        {
            _factory = factory;
            _items = new Dictionary<int, MediatekaItem>();
            _lists = new Dictionary<int, IMediatekaList>();
        }
        public Mediateka(IDictionary<int, MediatekaItem> items, 
                         AbstractPlayerFactory factory)
        {
            _factory = factory;
            _items = items;
            _lists = new Dictionary<int, IMediatekaList>();
        }
        public Mediateka(IDictionary<int, IMediatekaList> lists,
                         AbstractPlayerFactory factory)
        {
            _factory = factory;
            _items = new Dictionary<int, MediatekaItem>();
            _lists = lists;
        }
        public Mediateka(IDictionary<int, MediatekaItem> items,
                         IDictionary<int, IMediatekaList> lists,
                         AbstractPlayerFactory factory)
        {
            _factory = factory;
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

        public void Play(MediatekaItem item)
        {
            var player = _factory.CreatePlayer(item);
            player.Play(item);
        }
        public void Play(IMediatekaList list)
        {
            var player = _factory.CreatePlayer(list);
            player.Play(list);
        }

        public void PlayItemById(int id)
        {
            var item = FindItemById(id);
            
            if(item != null)
            {
                var player = _factory.CreatePlayer(item);
                player.Play(item);
            }
            else
            {
                //todo smth
            }
        }
        public void PlayListById(int id)
        {
            var list = FindListById(id);

            if (list != null)
            {
                var player = _factory.CreatePlayer(list);
                player.Play(list);
            }
            else
            {
                //todo smth
            }
        }
    }
}
