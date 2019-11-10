using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne
{
    public static class MyList
    {
        public static void ShowList()
        {
            List<double> doubles = new List<double>();
            doubles.Add(1.5);
            doubles.Add(2.8);
            doubles.Add(3.2);
            doubles.Add(5.1);

            foreach (var number in doubles)
            {
                Console.WriteLine(number);
            }
        }
    }

}
