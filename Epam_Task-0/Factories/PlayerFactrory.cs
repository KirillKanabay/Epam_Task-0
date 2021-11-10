using Epam_Task_0.Interfaces;
using Epam_Task_0.Interfaces.Generic;
using Epam_Task_0.Models;
using Epam_Task_0.Models.Players;
using System;

namespace Epam_Task_0.Factories
{
    public class PlayerFactrory : AbstractPlayerFactory
    {
        public override IPlayer CreatePlayer(MediatekaItem item)
        {
            if(item is Image)
            {
                return new ImagePlayer();
            }
            else if(item is MusicTrack)
            {
                return new MusicTrackPlayer();
            }
            else if(item is Video)
            {
                return new VideoPlayer();
            }
            else
            {
                throw new ArgumentException("Unsupported media");
            }
        }
        public override IPlayer CreatePlayer(IMediatekaList list)
        {
            if (list is IMediatekaList<Image>)
            {
                return new ImagePlayer();
            }
            else if (list is IMediatekaList<MusicTrack>)
            {
                return new MusicTrackPlayer();
            }
            else if (list is IMediatekaList<Video>)
            {
                return new VideoPlayer();
            }
            else
            {
                throw new ArgumentException("Unsupported media");
            }
        }
    }
}
