using System.Drawing;
using DesignPatternsDemo.StructuralPattern.BridgePattern.Color;
using DesignPatternsDemo.StructuralPattern.BridgePattern.Shape;

namespace DesignPatternsDemo.StructuralPattern.BridgePattern
{
    public class Bridge
    {
        private IColor _color;

        private IShape _shape;

        public Bridge(IColor color, IShape shape)
        {
            _color = color;
            _shape = shape;
        }

        public string GetColor()
        {
            return _color.GetColor();
        }

        public string GetShape()
        {
            return _shape.GetShape();
        }
    }
}