using DesignPatternsDemo.StructuralPattern.BridgePattern;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern
{
    public class BridgePatternTests
    {
        [Fact]
        public void ShouldGetRedCircle()
        {
            var painter = new CirclePainter(new ColorA());

            Assert.Equal("a paper with red circle", painter.Draw());
        }
        
        [Fact]
        public void ShouldGetGreenCircle()
        {
            var painter = new CirclePainter(new ColorB());

            Assert.Equal("a paper with green circle", painter.Draw());
        }
        
        [Fact]
        public void ShouldGetGreenLine()
        {
            var painter = new LinePainter(new ColorA());

            Assert.Equal("a paper with red line", painter.Draw());
        }
        
        [Fact]
        public void ShouldGetRedLine()
        {
            var painter = new LinePainter(new ColorB());

            Assert.Equal("a paper with green line", painter.Draw());
        }
    }
}