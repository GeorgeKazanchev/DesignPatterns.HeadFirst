using DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Facade._HomeTheater.Data;

namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Facade._HomeTheater.Facade
{
    public class HomeTheaterFacade
    {
        public HomeTheaterFacade(Amplifier amplifier, DvdPlayer dvdPlayer, Projector projector, Screen screen,
            TheaterLights lights, PopcornPopper popper)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _popper = popper;
        }

        private readonly Amplifier _amplifier;
        private readonly DvdPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly Screen _screen;
        private readonly TheaterLights _lights;
        private readonly PopcornPopper _popper;

        public void StartMovie(Movie movie)
        {
            _popper.On();
            _popper.Pop();
            _lights.SetDim(10);
            _screen.Down();
            _projector.On();
            _projector.SetWideScreenMode();
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void StopMovie()
        {
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}