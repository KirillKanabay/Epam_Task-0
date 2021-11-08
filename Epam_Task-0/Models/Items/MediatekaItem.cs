using Epam_Task_0.Interfaces;

namespace Epam_Task_0.Models
{
    public abstract class MediatekaItem
    {
        public int Id { get; }
        public string Name { get; set; }
        protected MediatekaItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
