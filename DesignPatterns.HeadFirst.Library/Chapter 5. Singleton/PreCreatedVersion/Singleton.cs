namespace DesignPatterns.HeadFirst.Library.Chapter_5._Singleton.PreCreatedVersion
{
    public class Singleton
    {
        private Singleton() { }

        private static readonly Singleton? instance = new();
        
        public static Singleton GetInstance() => instance;
    }
}