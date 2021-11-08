using System;

namespace Epam_Task_0.Models
{
    public class Image : MediatekaItem
    {
        public Resolution Resolution { get; }

        public Image(int id, string name, Resolution resolution) : base(id, name)
        {
            Resolution = resolution;
        }
    }
}
