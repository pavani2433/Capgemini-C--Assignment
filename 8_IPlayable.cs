using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    interface IPlayable
    {
        void Play();
    }
    public class MusicPlayer : IPlayable
    {
        public string Song { get; set; }

        public void Play()
        {
            Console.WriteLine($"Playing music: {Song}");
        }
    }

    public class VideoPlayer : IPlayable
    {
        public string Video { get; set; }

        public void Play()
        {
            Console.WriteLine($"Playing video: {Video}");
        }
    }

    class Program
    {
        static void Main()
        {
            IPlayable mediaPlayer;

            Console.WriteLine("Enter details for Music Player:");
            MusicPlayer musicPlayer = new MusicPlayer();
            Console.Write("Enter Song Name: ");
            musicPlayer.Song = Console.ReadLine();

            mediaPlayer = musicPlayer;
            Console.WriteLine("\nMusic Player:");
            mediaPlayer.Play();

            Console.WriteLine("\nEnter details for Video Player:");
            VideoPlayer videoPlayer = new VideoPlayer();
            Console.Write("Enter Video Name: ");
            videoPlayer.Video = Console.ReadLine();

            mediaPlayer = videoPlayer;
            Console.WriteLine("\nVideo Player:");
            mediaPlayer.Play();
        }
    }
}
