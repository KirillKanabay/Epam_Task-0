using Epam_Task_0.Interfaces.Generic;
using Epam_Task_0.Models;
using System;

namespace Epam_Task_0.Interfaces
{
    public interface IMediateka
    {
        void AddItem(MediatekaItem item);
        void AddList(IMediatekaList list);
        void AddList<TItem>(IMediatekaList<TItem> list)
            where TItem : MediatekaItem;
        MediatekaItem FindItem(Func<MediatekaItem, bool> predicate);
        MediatekaItem FindItemById(int id);
        IMediatekaList FindList(Func<IMediatekaList, bool> predicate);
        IMediatekaList FindListById(int id);
        void RemoveItem(int id);
        void RemoveList(int id);
    }
}