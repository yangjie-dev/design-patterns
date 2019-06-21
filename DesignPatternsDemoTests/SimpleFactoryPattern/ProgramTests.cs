using DesignPatternsDemo.SimpleFactoryPattern;
using Xunit;

namespace DesignPatternsDemoTests.SimpleFactoryPattern
{
    public class ProgramTests
    {
        [Fact]
        public void ShouldGetProductA()
        {
            var product = Factory.CreateInstanceBinderProduct("A");

            Assert.Equal("A is used", product.Use());
        }
    }
}