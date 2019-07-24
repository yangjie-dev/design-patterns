using System;

namespace DesignPatternsDemo.StructuralPattern.FacadePattern
{
    public class TheaterLights
    {
        public void Dim(int i)
        {
            Console.WriteLine("TheaterLights Dim");
        }

        public void On()
        {
            Console.WriteLine("TheaterLights On");
        }
    }
}