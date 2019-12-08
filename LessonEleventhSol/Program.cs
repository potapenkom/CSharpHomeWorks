using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonEleventhSol
{
    class Program
    {
        delegate void UsersDelegate();
        static void Main(string[] args)
        {
            ThreadStart threadDelegate = SecondThreadMethodClass.SecondThreadMethod;
            Thread thread = new Thread(threadDelegate);
            thread.Start();
            var FibNumber = FibonachiClass.Fibonachi(10);
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Main thread Id: {threadId}");
            Console.WriteLine($"\n Fibonachi number in main Thread is {FibNumber}.");
            Console.Read();
            UsersDelegate usersDelegate = new UsersDelegate(WriteTextClass.WriteText);
            usersDelegate.BeginInvoke(null, null);
            Console.WriteLine("Продолжается работа метода Main");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("*");
            }

            Console.ReadLine();
        }
    }
}
