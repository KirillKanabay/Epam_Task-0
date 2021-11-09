using Epam_Task_0.Models;

namespace Epam_Task_0.Interfaces.Generic
{
    public interface IPlayer<T> : IPlayer
        where T : MediatekaItem
    {
        new T CurrentItem { get; }
        void Play(T item);
        void Play(IMediatekaList<T> list);
    }
}
