using System;

namespace KV.PatternFacade
{
    public class HomeTheaterFacade
    {
        private Amplifier amplificador;
        private Tuner tuner;
        private DvdPlayer dvdPlayer;
        private CdPlayer cdPlayer;
        private Projector projector;
        private TheaterLights theaterLights;
        private Screen screen;
        private PopcornPopper popcornPopper;

        public HomeTheaterFacade(Amplifier amplificador, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer,
            Projector projector, TheaterLights theaterLights, Screen screen, PopcornPopper popcornPopper)
        {
            this.amplificador = amplificador;
            this.tuner = tuner;
            this.dvdPlayer = dvdPlayer;
            this.cdPlayer = cdPlayer;
            this.projector = projector;
            this.theaterLights = theaterLights;
            this.screen = screen;
            this.popcornPopper = popcornPopper;
        }

        public void WachtMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popcornPopper.On();
            popcornPopper.Pop();
            theaterLights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amplificador.On();
            amplificador.SetDvd(dvdPlayer);
            amplificador.SetSurroundSound();
            amplificador.SetVolume(5);
            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popcornPopper.Off();
            theaterLights.On();
            screen.Up();
            projector.Off();
            amplificador.Off();
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();
        }
    }
}