using System;

namespace LessonFour
{
    class Program
    {
        delegate T CreateWolf<T,R>( R obj);
        static void Main(string[] args)
        {
            CreateWolf<BigBadWolf, string> wolf;
            wolf = name => new BigBadWolf(name);
            wolf("Grey Wolf").GetInfo();
            MessageSender publisher = new MessageSender();
            publisher.EventMessage += () => Console.WriteLine("Wolf has a voice");
            publisher.InvokeEvent();
        } 
    }
}
