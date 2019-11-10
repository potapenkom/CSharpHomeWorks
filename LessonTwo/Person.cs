using System;
using System.Collections.Generic;
using System.Text;

namespace LessonTwo
{
    public class Person<T, R> where T : struct where R : Shape
    {
        private T id;
        private R shape;
        public Person(T id, R Shape)
        {
            this.id = id;
            shape = Shape;
        }
        public void ShowData()
        {
            Console.WriteLine($"id: Type - {typeof(T).ToString()}, Value - {id}");
            Console.WriteLine($"Shape: Type - {typeof(R).ToString()}, Value - {shape}");
        }

        public (T, R) GetData()
        {
            return (id, shape);
        }
    }
}
