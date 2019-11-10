using System;
using System.Collections;
using System.Text;

namespace LessonOne
{
    public static class MyArrayLst
    {
        public static void ShowArrayList()
        {
            ArrayList anything = new ArrayList();

            anything.Add("Cat");
            anything.Add(2);
            anything.Add('C');
            anything.Add(36.6);

            for (int i = 0; i < anything.Count; i++)
            {
                Console.WriteLine($"Element array list is {anything[i]}");
            }
        }
    }
}
