using System;
using System.Collections.Generic;
using System.Text;

namespace LessonTwo
{
    public class Shape
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        private int age;
        public int Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Age must be more 17");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
        public Shape(string Name, string Surename, int Age)
        {
            this.Name = Name;
            this.Surename = Surename;
            this.Age = Age;
        }
    }
}

