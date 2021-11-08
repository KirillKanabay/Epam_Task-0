using System;
using Epam_Task_0.Interfaces.Generic;

namespace Epam_Task_0.Models.Players
{
    public class ImagePlayer : IPlayer<Image>
    {
        public Image CurrentItem { get; private set; }
        public bool IsActive => CurrentItem != null; 

        public void Play(Image image)
        {
            CurrentItem = image;

            Console.WriteLine($"Image: #{CurrentItem.Id} " +
                                       $"Name:{CurrentItem.Name} " +
                                       $"Resolution:{CurrentItem.Resolution}");

            Stop();
        }

        public void Play(IMediatekaList<Image> images)
        {
            foreach(var image in images)
            {
                Play(image);
            }
        }

        public void Stop()
        {
            CurrentItem = null;
        }
    }
}
