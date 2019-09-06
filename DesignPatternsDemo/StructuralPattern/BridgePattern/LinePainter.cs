namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    public class LinePainter : Painter
    {
        private readonly IColor _color;

        public LinePainter(IColor color) : base(color)
        {
            _color = color;
        }

        public override string Draw()
        {
            return string.Join(" ", base.Draw(), "line");
        }
    }
}