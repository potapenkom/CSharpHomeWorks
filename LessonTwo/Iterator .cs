using System;
using System.Collections.Generic;
using System.Text;

namespace LessonTwo
{
   public class Iterator
    {
        List<string> names;

        public Iterator(UserCollection col)
        {
            names = col.names;
        }
        public void AddItem(string item)
        {
            names.Add(item);
        }

        public void RemoveItem(string name)
        {
            if (names.Count > 5)
            {
                names.Remove(name);
            }
            else
            {
                Console.WriteLine($"In the list of {names.Count} elements.");
            }
        }
        int currentPosition = -1;

        public object Current
        {
            get
            {
                return names[currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (currentPosition < names.Count - 1)
            {
                currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentPosition = -1;
        }
    }
}

