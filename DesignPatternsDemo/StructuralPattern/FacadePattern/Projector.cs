using System;

namespace DesignPatternsDemo.StructuralPattern.FacadePattern
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector On");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector WideScreenMode");
        }

        public void Off()
        {
            Console.WriteLine("Projector Off");
        }
    }
}