using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne.Dictionary
{
   public class Num : INum
    {
        private int num;
        public Num(int num)
        {
            this.num = num;
        }
        public int getNum()
        {
            return num;
        }
    }
}
