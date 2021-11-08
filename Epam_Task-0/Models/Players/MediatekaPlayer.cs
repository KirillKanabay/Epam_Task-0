using System;
using Epam_Task_0.Interfaces;
using Epam_Task_0.Interfaces.Generic;

namespace Epam_Task_0.Models.Players
{
    public class MediatekaPlayer : IPlayer
    {
        private readonly IPlayer<Image> _imagePlayer;
        private readonly IPlayer<Video> _videoPlayer;
        private readonly IPlayer<MusicTrack> _musicTrackPlayer;
        
        public MediatekaItem CurrentItem { get; private set; }
        public bool IsActive => CurrentItem != null;

        public MediatekaPlayer()
        {
            _imagePlayer = new ImagePlayer();
            _videoPlayer = new VideoPlayer();
            _musicTrackPlayer = new MusicTrackPlayer();
        }

        public void Play(MediatekaItem mediatekaItem)
        {
            if(mediatekaItem is Image)
            {
                Play(_imagePlayer, (Image)mediatekaItem);
            }
            else if(mediatekaItem is Video)
            {
                Play(_videoPlayer, (Video)mediatekaItem);
            }
            else if(mediatekaItem is MusicTrack)
            {
                Play(_musicTrackPlayer, (MusicTrack)mediatekaItem);
            }
            else
            {
                throw new ArgumentException("Unsupported mediateka item", nameof(mediatekaItem));
            }
        }

        public void Play(IMediatekaList mediatekaItems)
        {
            foreach(var item in mediatekaItems)
            {
                Play(item);
            }
        }

        private void Play<TItem>(IPlayer<TItem> player, TItem item) 
            where TItem : MediatekaItem
        {
            CurrentItem = item;
            
            player.Play(item);
            
            Stop();
        }

        public void Stop()
        {
            CurrentItem = null;
        }
    }
}
