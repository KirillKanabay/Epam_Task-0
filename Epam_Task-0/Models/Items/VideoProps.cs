namespace Epam_Task_0.Models
{
    public readonly struct VideoProps
    {
        public Resolution Resolution { get; }
        public double Duration { get; }

        public VideoProps(Resolution resolution, double duration)
        {
            Resolution = resolution;
            Duration = duration;
        }
    }
}
