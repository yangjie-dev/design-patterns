using System;

namespace DesignPatternsDemo.StructuralPattern.FacadePattern
{
    public class Screen
    {
        public void Down()
        {
            Console.WriteLine("Screen Down");
        }

        public void Up()
        {
            Console.WriteLine("Screen Up");
        }
    }
}