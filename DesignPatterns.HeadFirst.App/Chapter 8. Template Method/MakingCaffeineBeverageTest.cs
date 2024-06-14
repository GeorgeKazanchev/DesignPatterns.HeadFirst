using DesignPatterns.HeadFirst.Library.Chapter_8._Template_Method;

namespace DesignPatterns.HeadFirst.App.Chapter_8._Template_Method
{
    public class MakingCaffeineBeverageTest
    {
        public static void Run()
        {
            Tea tea = new();
            Coffee coffee = new();
            PrepareBeverages(tea, coffee);
        }

        public static void PrepareBeverages(params CaffeineBeverage[] beverages)
        {
            foreach (var beverage in beverages)
            {
                PrepareSingleBeverage(beverage);
                Console.WriteLine("\n");
            }
        }

        public static void PrepareSingleBeverage(CaffeineBeverage beverage)
        {
            beverage.PrepareRecipe();
        }
    }
}