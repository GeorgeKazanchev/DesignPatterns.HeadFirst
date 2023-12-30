namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects
{
    public class Stereo
    {
        public Stereo(string location)
        {
            Location = location;
        }

        public string Location { get; private set; }

        public uint Volume { get; private set; }

        public void On()
        {

        }

        public void Off()
        {

        }

        public void SetCd()
        {

        }

        public void SetDvd()
        {

        }

        public void SetRadio()
        {

        }

        public void SetVolume(uint volume)
        {
            Volume = volume;
        }
    }
}