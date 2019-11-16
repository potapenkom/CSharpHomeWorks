using System;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape misha = new Shape("Misha", "Potapenko", 33);
            Person<int, Shape> person = new Person<int, Shape>(1, misha);
            person.ShowData();
            UserCollection col = new UserCollection();
            col.UserNames.Add("crank arm");
            col.UserNames.Add("chain ring");
            col.UserNames.GetEnumerator().MoveNext();
        }
    }
}
