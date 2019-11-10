using System;
using System.Collections;
using System.Text;

namespace LessonOne
{
    public static class MyStack
    {
        public static void ShowStack()
        {
            Stack buyers = new Stack();

            buyers.Push("Tony");
            buyers.Push("Mary");
            buyers.Push("George");
            buyers.Push("Bill");

            foreach (var buyer in buyers)
            {
                Console.WriteLine($"Buyer in Stack: {buyer}");
            }
        }
    }
}
