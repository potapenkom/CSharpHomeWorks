using System;
using System.Collections;
using System.Text;

namespace LessonOne
{
    public static class MyQueue
    {
        public static void ShowQueue()
        {
            Queue buyers = new Queue();

            buyers.Enqueue("Tony");
            buyers.Enqueue("Mary");
            buyers.Enqueue("George");
            buyers.Enqueue("Bill");

            foreach (var buyer in buyers)
            {
                Console.WriteLine($"Buyer in Queue: {buyer}");
            }
        }
    }
}
