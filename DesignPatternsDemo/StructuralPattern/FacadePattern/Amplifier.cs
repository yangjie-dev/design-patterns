using System;

namespace DesignPatternsDemo.StructuralPattern.FacadePattern
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier On");
        }

        public void SetDvd()
        {
            Console.WriteLine("Amplifier SetDvd");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier SetSurroundSound");
        }

        public void SetVolume(int i)
        {
            Console.WriteLine("Amplifier SetVolume");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier Off");
        }
    }
}