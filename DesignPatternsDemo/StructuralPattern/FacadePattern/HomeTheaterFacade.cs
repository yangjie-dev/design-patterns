using System;

namespace DesignPatternsDemo.StructuralPattern.FacadePattern
{
    public class HomeTheaterFacade
    {
        private Amplifier _amp;

        private DvdPlayer _dvd;

        private Projector _projector;

        private TheaterLights _lights;

        private Screen _screen;

        private PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amp, DvdPlayer dvd, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            _amp = amp;
            _dvd = dvd;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie... ");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd();
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}