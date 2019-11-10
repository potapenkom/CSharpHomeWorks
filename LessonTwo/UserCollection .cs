using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace LessonTwo
{
   public class UserCollection : IEnumerable
    {
        List<string> names = new List<string>();
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
    }
}
