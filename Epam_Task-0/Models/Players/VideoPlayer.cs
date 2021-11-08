using System;
using Epam_Task_0.Interfaces.Generic;

namespace Epam_Task_0.Models.Players
{
    public class VideoPlayer : IPlayer<Video>
    {
        public Video CurrentItem { get; private set; }
        public bool IsActive => CurrentItem != null;

        public void Play(Video video)
        {
            CurrentItem = video;

            Console.WriteLine($"Video: #{CurrentItem.Id} " +
                                       $"Name: {CurrentItem.Name} " +
                                       $"Duration: {CurrentItem.Props.Duration} " +
                                       $"Resolution: {CurrentItem.Props.Resolution}");

            Stop();
        }

        public void Play(IMediatekaList<Video> videos)
        {
            foreach (var video in videos)
            {
                Play(video);
            }
        }

        public void Stop()
        {
            CurrentItem = null;
        }
    }
}
