using Epam_Task_0.Interfaces.Generic;
using System.Collections;
using System.Collections.Generic;

namespace Epam_Task_0.Models.Lists
{
    public class ImageList : IMediatekaList<Image>
    {
        private readonly ICollection<Image> _items;

        public int Id { get; }

        public ImageList(int id)
        {
            Id = id;
            _items = new List<Image>();
        }

        public ImageList(int id, ICollection<Image> items)
        {
            _items = items;
        }

        public void Add(Image item)
        {
            _items.Add(item);
        }

        public void Remove(Image item)
        {
            _items.Remove(item);
        }

        public IEnumerator<Image> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
