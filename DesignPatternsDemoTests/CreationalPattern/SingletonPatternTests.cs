using DesignPatternsDemo.CreationalPattern.SingletonPattern;
using Xunit;

namespace DesignPatternsDemoTests.CreationalPattern
{
    public class SingletonPatternTests
    {
        [Fact]
        public void ShouldGetOnlyOneSingleton()
        {
            // can not new singleton, because private contructor
            // var s = new Singleton();

            var singleton = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();

            Assert.NotNull(singleton);
            Assert.Equal(singleton,singleton2);
        }
    }
}