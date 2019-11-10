using System;

namespace LessonThree
{
    class Program
    {
        
        delegate void ExampleDelegate();
        delegate BigBadWolf CreateWolf(string name);
        delegate void WoofWolf();
        static void Main(string[] args)
        {
            CreateWolf wolf = delegate (string name)
            {
                var newWolf = new BigBadWolf(name);
                return newWolf;
            };
            wolf("Grey Wolf").GetInfo();
            Console.WriteLine();
            BigBadWolf myWolf = new BigBadWolf("Grey");
            WoofWolf woof = myWolf.Woof;
            ExampleDelegate exampleHello = Greeting.Hello;
            ExampleDelegate exampleBye = Greeting.Bye;
            ExampleDelegate exampleGoodMorning = Greeting.GoodMorning;
            ExampleDelegate GoodEvening = Greeting.GoodEvening;
            ExampleDelegate combinedExample = exampleHello + exampleBye + exampleGoodMorning + GoodEvening;
            combinedExample();
            ExampleDelegate combinedHelloBye = combinedExample - exampleGoodMorning - GoodEvening;
            combinedHelloBye();
            ExampleDelegate combinedMorningEvening = combinedExample - exampleHello - exampleBye;
            combinedMorningEvening();
        }
    }
}
