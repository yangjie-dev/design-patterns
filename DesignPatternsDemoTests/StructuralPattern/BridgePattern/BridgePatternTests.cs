using DesignPatternsDemo.StructuralPattern.BridgePattern;
using DesignPatternsDemo.StructuralPattern.BridgePattern.Color;
using DesignPatternsDemo.StructuralPattern.BridgePattern.Shape;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern.BridgePattern
{
    public class BridgePatternTests
    {
        [Fact]
        public void ShouldGetRedTriangleByBridge()
        {
            var bridge = new Bridge(new RedColor(), new TriangleShape());

            Assert.Equal(bridge.GetColor(), "Red");
            
            Assert.Equal(bridge.GetShape(), "Triangle");
        }
    }
}