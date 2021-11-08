using Epam_Task_0.Interfaces.Generic;
using System.Collections.Generic;
using System.Collections;

namespace Epam_Task_0.Models.Lists
{
    public class MusicTrackList : IMediatekaList<MusicTrack>
    {
        private readonly ICollection<MusicTrack> _items;

        public int Id { get; }

        public MusicTrackList(int id)
        {
            Id = id;
            _items = new List<MusicTrack>();
        }

        public MusicTrackList(int id, ICollection<MusicTrack> items)
        {
            Id = id;
            _items = items;
        }

        public void Add(MusicTrack item)
        {
            _items.Add(item);
        }

        public void Remove(MusicTrack item)
        {
            _items.Remove(item);
        }

        public IEnumerator<MusicTrack> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
