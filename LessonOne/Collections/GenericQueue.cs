using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne
{
    public static class GenericQueue
    {
        public static void ShowGenericQueue()
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Artur");
            names.Enqueue("Ivan");
            names.Enqueue("Liza");
            names.Enqueue("Maria");
            foreach (var name in names)
            {
                Console.WriteLine($"It's name from Queue: {name}");
            }
        }
    }
}
