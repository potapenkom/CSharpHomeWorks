using System;

namespace LessonFour
{
    class Program
    {
        delegate T CreateWolf<T>(T obj);

        static void Main(string[] args)
        {
            CreateWolf<BigBadWolf> wolf;
            wolf = name => new BigBadWolf(name);
        }
    }
}
