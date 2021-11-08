using Epam_Task_0.Models;
using System.Collections.Generic;

namespace Epam_Task_0.Interfaces
{
    public interface IMediatekaList : IEnumerable<MediatekaItem>  
    {
        int Id { get; }
        void Add(MediatekaItem item);
        void Remove(MediatekaItem item);
    }
}
