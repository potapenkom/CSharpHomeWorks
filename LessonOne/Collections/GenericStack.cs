using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne
{
    public static class GenericStack
    {
        public static void ShowGenericStack()
        {
            Stack<string> names = new Stack<string>();
            names.Push("Artur");
            names.Push("Ivan");
            names.Push("Liza");
            names.Push("Maria");
            foreach (var name in names)
            {
                Console.WriteLine($"It's name from stack: {name}");
            }
        }
    }
}
