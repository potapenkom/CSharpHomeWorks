using System;

namespace LessonFive
{
    class Program
    {
        public delegate void MyDelegate(string text);
        static void Main(string[] args)
        {
            Action<string> printActionDel = str => Console.WriteLine(str);
            NonStaticClass.StaticMethod(printActionDel);
            MyDelegate myDelegate = delegate (string mes)
            {
                Console.WriteLine(mes);
            };
           // StaticClass.CallDelegate(myDelegate("string"));
        }   
    }
}
