namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects
{
    public class Hottub
    {
        public Hottub(int temperature = 20)
        {
            Temperature = temperature;
        }

        public int Temperature { get; private set; } 

        public void On()
        {
            Console.WriteLine("Hottub is switched on");
        }

        public void Off()
        {
            Console.WriteLine("Hottub is switched off");
        }


        public void JetsOn()
        {
            throw new NotImplementedException();
        }

        public void JetsOff()
        {
            throw new NotImplementedException();
        }

        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
        }
    }
}