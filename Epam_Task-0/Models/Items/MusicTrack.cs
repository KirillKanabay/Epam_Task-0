using System;

namespace Epam_Task_0.Models
{
    public class MusicTrack : MediatekaItem
    {
        public double Duration { get; }
        public MusicTrack(int id, string name, double duration) : base(id, name)
        {
            Duration = duration;
        }
    }
}
