using System.Drawing;

namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    public class CirclePainter : Painter
    {
        private readonly IColor _color;

        public CirclePainter(IColor color) : base(color)
        {
            _color = color;
        }

        public override string Draw()
        {
            return string.Join(" ", base.Draw(), "circle");
        }
    }
}