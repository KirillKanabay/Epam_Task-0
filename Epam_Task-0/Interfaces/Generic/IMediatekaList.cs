using Epam_Task_0.Models;
using System.Collections.Generic;

namespace Epam_Task_0.Interfaces.Generic
{
    public interface IMediatekaList<TItem> : IEnumerable<TItem>, IMediatekaList
        where TItem : MediatekaItem
    { 
        void Add(TItem item);
        void Remove(TItem item);
    }
}
