using Epam_Task_0.Interfaces.Generic;
using System.Collections;
using System.Collections.Generic;

namespace Epam_Task_0.Models.Lists
{
    public class VideoList : IMediatekaList<Video>
    {
        private readonly ICollection<Video> _items;
        public int Id { get; }
        
        public VideoList(int id)
        {
            Id = id;
            _items = new List<Video>();
        }

        public VideoList(int id, ICollection<Video> items)
        {
            Id = id;
            _items = items;
        }

        public void Add(Video item)
        {
            _items.Add(item);
        }

        public void Remove(Video item)
        {
            _items.Remove(item);
        }

        public IEnumerator<Video> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
