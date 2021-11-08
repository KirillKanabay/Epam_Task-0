using System;
using Epam_Task_0.Interfaces;
using Epam_Task_0.Interfaces.Generic;

namespace Epam_Task_0.Models.Players
{
    public class MusicTrackPlayer : IPlayer<MusicTrack>
    {
        public MusicTrack CurrentItem { get; private set; }
        public bool IsActive => CurrentItem != null;
        
        public void Play(MusicTrack musicTrack)
        {
            CurrentItem = musicTrack;

            Console.WriteLine($"Music: #{CurrentItem.Id} " +
                                       $"Name: {CurrentItem.Name} " +
                                       $"Duration: {CurrentItem.Duration}");

            Stop();
        }

        public void Play(IMediatekaList<MusicTrack> musicTracks)
        {
            foreach (var musicTrack in musicTracks)
            {
                Play(musicTrack);
            }
        }

        public void Stop()
        {
            CurrentItem = null;
        }
    }
}
