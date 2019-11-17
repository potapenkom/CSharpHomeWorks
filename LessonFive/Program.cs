using System;

namespace LessonFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<string> printActionDel = str => Console.WriteLine(str);
            //NonStaticClass.StaticMethod(printActionDel);
            //MyDelegate myDelegate = str => Console.WriteLine(str);
            //StaticClass.CallDelegate(myDelegate);
            //Human newHuman = new Human();
            //Console.WriteLine(newHuman.MostImportantBodyPart);
            //Console.WriteLine();
            //newHuman.Evolve();
            //Console.WriteLine(newHuman.MostImportantBodyPart);
            SelectedPersons.ShowExtensionMethodSyntax();
        }   
    }
}
