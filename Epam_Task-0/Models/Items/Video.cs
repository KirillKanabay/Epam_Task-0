namespace Epam_Task_0.Models
{
    public class Video : MediatekaItem
    {
        public VideoProps Props{ get; }
        public Video(int id, string name, VideoProps props) : base(id, name)
        {
            Props = props;
        }
    }
}
