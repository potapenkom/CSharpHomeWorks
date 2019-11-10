using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFour
{
    public class BigBadWolf
    {
        string name;

        public BigBadWolf(string name)
        {
            this.name = name;
        }
        public void Woof()
        {
            Console.WriteLine($"{name} has a voice");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Big Bad Wolf's name is: {name}");
        }
    }
}
