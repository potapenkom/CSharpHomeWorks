using System;

namespace LessonFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printActionDel = str => Console.WriteLine(str);
            NonStaticClass.StaticMethod(printActionDel);
            Console.WriteLine("End first task");
            MyDelegate myDelegate = str => Console.WriteLine(str);
            StaticClass.CallDelegate(myDelegate);
            Console.WriteLine("End second task");
            Human newHuman = new Human();
            Console.WriteLine(newHuman.MostImportantBodyPart);
            Console.WriteLine();
            newHuman.Evolve();
            Console.WriteLine(newHuman.MostImportantBodyPart);
            Console.WriteLine("End third task");
            SelectedPersons.ShowExtensionMethodSyntax();
            Console.WriteLine("End fourth task");
        }   
    }
}
