using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFive
{
    delegate void MyDelegate();
   
    static class StaticClass
    {
        public static void CallDelegate(MyDelegate myDelegate)
        {
             myDelegate();
        }
    }
}
