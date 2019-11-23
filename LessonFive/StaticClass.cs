using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFive
{
    delegate void MyDelegate(string str);
   
    static class StaticClass
    {
        public static void CallDelegate(MyDelegate myDelegate)
        {
             myDelegate("Hello from static class.");
        }
    }
}
