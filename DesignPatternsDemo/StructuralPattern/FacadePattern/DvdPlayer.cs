using System;

namespace DesignPatternsDemo.StructuralPattern.FacadePattern
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DvdPlayer On");
        }

        public void Play(string movie)
        {
            Console.WriteLine("DvdPlayer Play \"{0}\"", movie);
        }

        public void Stop()
        {
            Console.WriteLine("DvdPlayer Stop");
        }

        public void Eject()
        {
            Console.WriteLine("DvdPlayer Eject");
        }

        public void Off()
        {
            Console.WriteLine("DvdPlayer Off");
        }
    }
}