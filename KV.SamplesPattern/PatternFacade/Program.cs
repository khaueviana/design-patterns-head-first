namespace PatternFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade theaterFacade = new HomeTheaterFacade(new Amplifier(), new Tuner(), new DvdPlayer(), new CdPlayer(),
                new Projector(), new TheaterLights(), new Screen(), new PopcornPopper());

            theaterFacade.WachtMovie("Meia-noite em Paris");
            theaterFacade.EndMovie();
        }
    }
}