using System;

namespace LessonThree
{
    class Program
    {
        
        delegate void ExampleDelegate();
        delegate BigBadWolf ShowDelegates(string name);
        delegate void Message();    
        static void Main(string[] args)
        {
            ShowDelegates show = delegate (string name)
             {
                 var wolf = new BigBadWolf(name);
                 return wolf;
             };
            show("Grey Wolf").GetInfo();
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
