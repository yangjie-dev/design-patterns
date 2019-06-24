using DesignPatternsDemo.CreationalPattern.FactoryMethodPattern;
using Xunit;

namespace DesignPatternsDemoTests.CreationalPattern.FactoryMethodPattern
{
    public class FactoryMethodPatternTests
    {
        [Fact]
        public void ShouldGetProductA()
        {
            var factory = new FactoryA();

            var result = factory.CreateProduct().Use();
            
            Assert.Equal("A is used", result);
        }
    }
}