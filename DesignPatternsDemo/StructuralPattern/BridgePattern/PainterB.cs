namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    public class PainterB : Painter
    {
        private readonly IColor _color;

        public PainterB(IColor color) : base(color)
        {
            _color = color;
        }

        public override string Draw()
        {
            return string.Join(" ", base.Draw(), "line");
        }
    }
}