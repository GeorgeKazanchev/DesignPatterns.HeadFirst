namespace DesignPatterns.HeadFirst.Library.Chapter_8._Template_Method
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            var userAnswer = true;  //  Imitates the user's answer
            return userAnswer;
        }
    }
}