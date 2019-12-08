using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonEleventhSol
{
    public static class SecondThreadMethodClass
    {
        public static void SecondThreadMethod()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Thread Id: {threadId}");

        }
    }
}
