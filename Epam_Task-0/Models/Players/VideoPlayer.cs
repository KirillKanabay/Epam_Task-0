using System;
using Epam_Task_0.Interfaces.Generic;

namespace Epam_Task_0.Models.Players
{
    public class VideoPlayer : BasePlayer<Video>
    {
        public override void Play(Video video)
        {
            CurrentItem = video;

            Console.WriteLine($"Video: #{CurrentItem.Id} " +
                                       $"Name: {CurrentItem.Name} " +
                                       $"Duration: {CurrentItem.Props.Duration} " +
                                       $"Resolution: {CurrentItem.Props.Resolution}");

            Stop();
        }
    }
}
