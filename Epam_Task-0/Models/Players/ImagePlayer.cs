using System;
using Epam_Task_0.Interfaces.Generic;

namespace Epam_Task_0.Models.Players
{
    public class ImagePlayer : BasePlayer<Image>
    {
        public override void Play(Image image)
        {
            CurrentItem = image;

            Console.WriteLine($"Image: #{CurrentItem.Id} " +
                                       $"Name:{CurrentItem.Name} " +
                                       $"Resolution:{CurrentItem.Resolution}");

            Stop();
        }
    }
}
