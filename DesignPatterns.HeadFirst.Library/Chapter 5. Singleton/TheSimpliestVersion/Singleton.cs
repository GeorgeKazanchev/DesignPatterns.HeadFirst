namespace DesignPatterns.HeadFirst.Library.Chapter_5._Singleton.TheSimpliestVersion
{
    public class Singleton
    {
        private Singleton() {}

        private static Singleton? instance;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}