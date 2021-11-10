using Epam_Task_0.Factories;
using Epam_Task_0.Interfaces;
using Epam_Task_0.Interfaces.Generic;
using Epam_Task_0.Models;
using Epam_Task_0.Models.Lists;

namespace Epam_Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediateka mediateka = new Mediateka();

            Image img1 = new Image(id: 1, "1.png", new Resolution(1920, 1080));
            Image img2 = new Image(id: 2, "2.png", new Resolution(1920, 1080));
            Image img3 = new Image(id: 3, "3.png", new Resolution(1920, 1080));
            MusicTrack mt = new MusicTrack(id: 4, "mp3_1", 1.2);

            mediateka.AddItem(img1);
            mediateka.AddItem(img2);
            mediateka.AddItem(img3);

            IMediatekaList<Image> images = new MediatekaList<Image>(id: 1);

            images.Add(img1);
            images.Add(img2);
            images.Add(img3);

            mediateka.AddList(images);

            AbstractPlayerFactory factory = new PlayerFactrory();

            IPlayer player1 = factory.CreatePlayer(images);

            player1.Play(images);

            IMediatekaList<MusicTrack> music = new MediatekaList<MusicTrack>(id: 2);
            music.Add(new MusicTrack(4, "1", 1));
            music.Add(new MusicTrack(5, "2", 2));
            music.Add(new MusicTrack(6, "3", 3));

            IPlayer player2 = factory.CreatePlayer(music);

            player2.Play(music);
        }
    }
}
