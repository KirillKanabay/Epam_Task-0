using System;

namespace Epam_Task_0.Models.Players
{
    public class MusicTrackPlayer : BasePlayer<MusicTrack>
    {        
        public override void Play(MusicTrack musicTrack)
        {
            CurrentItem = musicTrack;

            Console.WriteLine($"Music: #{CurrentItem.Id} " +
                                       $"Name: {CurrentItem.Name} " +
                                       $"Duration: {CurrentItem.Duration}");

            Stop();
        }
    }
}
