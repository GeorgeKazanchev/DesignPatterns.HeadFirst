namespace DesignPatterns.HeadFirst.Library.Chapter_8._Template_Method
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            var userAnswer = false;  //  Imitates the user's answer
            return userAnswer;
        }
    }
}