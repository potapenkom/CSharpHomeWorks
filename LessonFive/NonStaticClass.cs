using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFive
{
    class NonStaticClass
    {
        public static void StaticMethod(Action<string> printActionDel)
        {
            printActionDel("Hello from not static class!");
        }
    }
}
