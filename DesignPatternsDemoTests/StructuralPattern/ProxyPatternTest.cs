using DesignPatternsDemo.StructuralPattern.ProxyPattern;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern
{
    public class ProxyPatternTest
    {
        [Fact]
        public void AdultShouldCanDriveCar()
        {
            var car = new ProxyCar(new Driver(25));

            Assert.Equal("Car has been driven!", car.DriveCar());
        }
        
        [Fact]
        public void ChildrenShouldCannotDriveCar()
        {
            var car = new ProxyCar(new Driver(15));

            Assert.Equal("Sorry, the driver is too young to drive.", car.DriveCar());
        }
    }
}