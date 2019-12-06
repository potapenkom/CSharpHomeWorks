using System;
using System.Collections.Generic;
using System.Text;

namespace LessonTenth
{
    public class UinfoClass 
    { 
        [UInfo("This is public method", "This is some Data")]
        public void GetIngo(string str1, string str2)
        {
            string Data = str1;
            string Desc = str2;
            Display();
        }
        [UInfo("This is private method", "This is some Data")]
        private void Display()
        {
            Console.WriteLine("This is UinfoClass");
        }
    }
}
