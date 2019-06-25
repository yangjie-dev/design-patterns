using DesignPatternsDemo.CreationalPattern.BuilderPattern;
using Xunit;

namespace DesignPatternsDemoTests.CreationalPattern
{
    public class BuilderPatternTests
    {
        [Fact]
        public void ShouldGetProductFormDirectorWithConcreteBuilder()
        {
            var director = new Director(new ConcreteBuilder());

            var product = director.Construct();
            
            Assert.Equal("A style", product._partA);
        }
    }
}