using System;
using System.Collections;
using System.Text;

namespace LessonOne
{
    public static class MyHashTable
    {
        public static void ShowHashTable()
        {
            Hashtable workers = new Hashtable();

            workers.Add("Tom", 300);
            workers.Add("Rocky", 500);
            workers.Add("Robert", 250);
            workers.Add("Adam", 450);

            foreach (DictionaryEntry element in workers)
            {
                Console.WriteLine($"Name:{element.Key}  \tSalary:{element.Value}");
            }
        }
    }
}
