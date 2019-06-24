using DesignPatternsDemo.CreationalPattern.SimpleFactoryPattern;
using Xunit;

namespace DesignPatternsDemoTests.CreationalPattern.SimpleFactoryPattern
{
    public class SimpleFactoryPatternTests
    {
        [Fact]
        public void ShouldGetProductA()
        {
            var product = Factory.CreateInstanceBinderProduct("A");

            Assert.Equal("A is used", product.Use());
        }
    }
}