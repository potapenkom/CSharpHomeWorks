using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LessonTenth
{
    public static class GetAttribute<T>
    {
        public static void ShowMethodsAttributes(T instance)
        {
            var methods = instance.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in methods)
                foreach (var attributeData in method.CustomAttributes)
                    Console.WriteLine(attributeData);
        }
    }
}
