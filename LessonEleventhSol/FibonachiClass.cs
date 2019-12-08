using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEleventhSol
{
    public static class FibonachiClass
    {
        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
