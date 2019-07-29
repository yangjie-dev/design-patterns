using System;
using System.Collections;

namespace DesignPatternsDemo.StructuralPattern.FlyweightPattern
{
    public class ShapeFactory
    {
        private readonly Hashtable _shapes = new Hashtable();

        public int TotalObjectsCreated => _shapes.Count;

        public IShape GetShape(string shapeName)
        {
            if (_shapes.ContainsKey(shapeName))
            {
                return _shapes[shapeName] as IShape;
            }

            switch (shapeName)
            {
                case "Rectangle":
                {
                    var shape = new Rectangle();
                    _shapes.Add("Rectangle", shape);
                    return shape;
                }

                case "Circle":
                {
                    var shape = new Circle();
                    _shapes.Add("Circle", shape);
                    return shape;
                }
                default:
                    throw new Exception("Factory cannot create the object specified");
            }
        }
    }
}