using Epam_Task_0.Models;

namespace Epam_Task_0.Interfaces
{
    public interface IPlayer
    {
        MediatekaItem CurrentItem { get; }
        bool IsActive { get; }
        void Play(MediatekaItem item);
        void Play(IMediatekaList list);
        void Stop();
    }
}
