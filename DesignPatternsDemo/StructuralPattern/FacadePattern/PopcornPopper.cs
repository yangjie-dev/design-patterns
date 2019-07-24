using System;

namespace DesignPatternsDemo.StructuralPattern.FacadePattern
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("PopcornPopper On");
        }

        public void Pop()
        {
            Console.WriteLine("PopcornPopper Pop");
        }

        public void Off()
        {
            Console.WriteLine("PopcornPopper Off");
        }
    }
}