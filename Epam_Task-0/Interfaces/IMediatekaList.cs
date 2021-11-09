using Epam_Task_0.Models;

namespace Epam_Task_0.Interfaces
{
    public interface IMediatekaList
    {
        int Id { get; }
        void Add(MediatekaItem item);
        void Remove(MediatekaItem item);
    }
}
