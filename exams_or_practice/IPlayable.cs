using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    interface IPlayable
    {
        public void Play();
    }
    class VideoPlayer:IPlayable
    {
        public void Play()
        {
            Console.WriteLine("I AM A BASIC EXAMPLE FOR IMPLEMENTING VIDEOPLAYER CLASS FROM INTERFACE ");
        }
    }
    class MusicPlayer:IPlayable
    {
        public void Play()
        {
            Console.WriteLine("i am a secondary example for implementing musicplayer class from iplayable");
        }
    }
}
