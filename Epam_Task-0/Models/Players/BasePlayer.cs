using Epam_Task_0.Interfaces;
using Epam_Task_0.Interfaces.Generic;

namespace Epam_Task_0.Models.Players
{
    public abstract class BasePlayer<TItem> : IPlayer<TItem>
        where TItem : MediatekaItem
    {
        public TItem CurrentItem { get; protected set; }
        public bool IsActive => CurrentItem != null;

        public abstract void Play(TItem item);
        public virtual void Play(IMediatekaList<TItem> list)
        {
            foreach(var item in list)
            {
                Play(item);
            }
        }
        public virtual void Stop()
        {
            CurrentItem = null;
        }

        MediatekaItem IPlayer.CurrentItem => CurrentItem;
        void IPlayer.Play(MediatekaItem item)
        {
            if (item is TItem)
            {
                Play((TItem)item);
            }
            else
            {
                //todo smth
            }
        }
        void IPlayer.Play(IMediatekaList list)
        {
            if(list is IMediatekaList<TItem>)
            {
                Play((IMediatekaList<TItem>)list);
            }
            else
            {
                //todo smth
            }
        }

    }
}
