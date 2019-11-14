using System;

namespace LessonFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printActionDel = str => Console.WriteLine(str);
            NonStaticClass.StaticMethod(printActionDel);  
        }
    }
}
