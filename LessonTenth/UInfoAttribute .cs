using System;
using System.Collections.Generic;
using System.Text;

namespace LessonTenth
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    class UInfoAttribute : Attribute
    {
        private readonly string desc;
        private readonly string data;

        public UInfoAttribute(string desc, string data)
        {
            this.desc = desc;
            this.data = data;
        }

        public void Display()
        {
            Console.WriteLine($"This is Desc: {desc}, and this is Data: {data}");
        }
    }
}
