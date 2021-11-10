using Epam_Task_0.Interfaces;
using Epam_Task_0.Models;

namespace Epam_Task_0.Factories
{
    public abstract class AbstractPlayerFactory
    {
        public abstract IPlayer CreatePlayer(MediatekaItem item);
        public abstract IPlayer CreatePlayer(IMediatekaList list);
    }
}
