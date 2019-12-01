using System;
using System.Reflection;

namespace LessonTenth
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfoExample.ShowFileInfo();
            GetAttribute<UinfoClass>.ShowMethodsAttributes(new UinfoClass());
        }
    }
}

