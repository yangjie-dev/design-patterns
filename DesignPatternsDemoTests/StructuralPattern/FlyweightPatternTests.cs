using DesignPatternsDemo.StructuralPattern.FlyweightPattern;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern
{
    public class FlyweightPatternTests
    {
        [Fact]
        public void Should()
        {
            var factory = new ShapeFactory();

            var shape = factory.GetShape("Rectangle");

            Assert.Equal("Printing Rectangle", shape.Print());

            shape = factory.GetShape("Circle");

            Assert.Equal("Printing Circle", shape.Print());

            shape = factory.GetShape("Rectangle");
           
            shape = factory.GetShape("Circle");

            Assert.Equal(2, factory.TotalObjectsCreated);
        }
    }
}