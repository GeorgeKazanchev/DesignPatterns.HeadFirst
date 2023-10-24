using System.Runtime.CompilerServices;

namespace DesignPatterns.HeadFirst.Library.Chapter_5._Singleton.TheSynchronizedVersion
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton? instance;

        [MethodImpl(MethodImplOptions.Synchronized)]
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