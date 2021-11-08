using Epam_Task_0.Models;

namespace Epam_Task_0.Interfaces.Generic
{
    public interface IPlayer<T> 
        where T : MediatekaItem
    {
        T CurrentItem { get; }
        bool IsActive { get; }
        void Play(T item);
        void Play(IMediatekaList<T> list);
        void Stop();
    }
}
