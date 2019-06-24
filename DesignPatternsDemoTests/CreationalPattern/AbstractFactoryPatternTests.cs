using DesignPatternsDemo.CreationalPattern.AbstractFactoryPattern.Factory;
using Xunit;

namespace DesignPatternsDemoTests.CreationalPattern
{
    public class AbstractFactoryPatternTests
    {
        [Fact]
        public void ShouldGetProductA1()
        {
            var factory = new ConcreteFactory1();

            var result = factory.CreateProductA().Use();
            
            Assert.Equal("A1 is used", result);
        }
    }
}