using DesignPatterns.HeadFirst.Library.Chapter_5._Singleton.TheSimpliestVersion;

namespace DesignPatterns.HeadFirst.App.Chapter_5._Singleton
{
    public class SingletonTest
    {
        public static void Run()
        {
            var singletonInstance = Singleton.GetInstance();
            var anotherSingletonInstance = Singleton.GetInstance();
            Console.WriteLine($"First singleton instance is equal to another one: {singletonInstance.Equals(anotherSingletonInstance)}");
        }
    }
}