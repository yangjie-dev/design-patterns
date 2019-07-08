using System.Drawing;

namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    public class PainterA : Painter
    {
        private readonly IColor _color;

        public PainterA(IColor color) : base(color)
        {
            _color = color;
        }

        public override string Draw()
        {
            return string.Join(" ", base.Draw(), "circle");
        }
    }
}