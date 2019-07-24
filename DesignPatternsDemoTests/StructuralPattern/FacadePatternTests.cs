using DesignPatternsDemo.StructuralPattern.FacadePattern;
using Xunit;

namespace DesignPatternsDemoTests.StructuralPattern
{
    public class FacadePatternTests
    {
        [Fact]
        public void ShouldWatchMovie()
        {
            var homeTheater = new HomeTheaterFacade(new Amplifier(), new DvdPlayer(), new Projector(),
                new TheaterLights(), new Screen(), new PopcornPopper());

            homeTheater.WatchMovie("The Shawshank Redemption");
            homeTheater.EndMovie();
        }
    }
}